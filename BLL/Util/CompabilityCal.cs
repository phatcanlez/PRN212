using BLL.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Util
{
    public class CompabilityCal
    {
        private readonly ElementService elementService = new();
        private readonly ElementCalculator elementCalculator = new();
        private readonly KoiPercentService koiPercentService = new();
        private readonly PointElementService pointElementService = new();
        private readonly PointShapeService pointOfShapeService = new();
        private readonly LifePalaceService lifePalaceService = new();
        private readonly LifePalaceDirectionService lifePlaceDirectionService = new();
        public double CalculateCompatibility(KoiVariety selectedKoi, string shapeId, string direction, DateTime dateOfBirth, string gender)
        {
            string dob = dateOfBirth.ToString("yyyy-MM-dd");
            double s1 = 0, s2 = 0, s3 = 0;
            bool hasS1 = false, hasS2 = false, hasS3 = false;

            if (selectedKoi != null)
            {
                var koiScore = CalculateKoiScore(selectedKoi.KoiType, dob);
                if (koiScore.HasValue)
                {
                    s1 = koiScore.Value;
                    hasS1 = true;
                }
            }

            if (!string.IsNullOrEmpty(shapeId))
            {
                var shapeScore = CalculateShapeScore(shapeId, dob);
                if (shapeScore.HasValue)
                {
                    s2 = shapeScore.Value;
                    hasS2 = true;
                }
            }

            if (!string.IsNullOrEmpty(direction))
            {
                var directionScore =  CalculateDirectionScore(direction, dob, gender);
                if (directionScore.HasValue)
                {
                    s3 = directionScore.Value;
                    hasS3 = true;
                }
            }

            double compatibility;
            if (hasS1 && hasS2 && hasS3)
                compatibility = (0.5 * s1 + 0.2 * s2 + 0.3 * s3);
            else if (hasS1 && hasS3)
                compatibility = (0.6 * s1 + 0.4 * s3);
            else if (hasS1 && hasS2)
                compatibility = (0.7 * s1 + 0.3 * s2);
            else if (hasS2 && hasS3)
                compatibility = (0.4 * s2 + 0.6 * s3);
            else if (hasS1)
                compatibility = s1;
            else if (hasS2)
                compatibility = s2;
            else if (hasS3)
                compatibility = s3;
            else
                compatibility = 0;

            return Math.Round(compatibility, 2);
        }

        public double? CalculateKoiScore(string koiType, string dob)
        {
            string element = elementService.GetElementByBirthYear(dob);
            var koiColors =  koiPercentService.getKoiPercent(koiType);
            double totalScore = 0;

            foreach (var color in koiColors)
            {
                var pointForColor = pointElementService.GetPointElementColor(element, color.ColorId);
                totalScore += pointForColor * color.Percentage;
            }
            return totalScore * 100;
        }

        public double? CalculateShapeScore(string shapeId, string dob)
        {

            string element = elementService.GetElementByBirthYear(dob);
            var shape = pointOfShapeService.GetPointOfShape(element, shapeId);
            return shape?.Point * 100;
        }

        public double? CalculateDirectionScore(string direction, string dob, string gender)
        {
            int[] lunarDate = LunarCalendarConverter.ConvertSolarToLunar(dob, 7);
            if (lunarDate == null) return null;

            int lunarYear = lunarDate[2];
            string lifePlace = lifePalaceService.CalculateFate(lunarYear.ToString(), gender);
            var point = lifePlaceDirectionService.GetLifePlaceDirectionById(lifePlace, direction);
            return point.PointOfDirection * 100;
        }
    }

    

}
