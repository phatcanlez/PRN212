using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PointElementService
    {
        private Swp391FengShuiKoiConsultingDbContext context = new Swp391FengShuiKoiConsultingDbContext();

        public float GetPointElementColor(string element, string color)
        {
            try
            {
                ElementColor existingElementColor = this.GetElementColorById(element, color);

                if (existingElementColor != null)
                {
                    return (float)existingElementColor.ColorPoint;
                }

                return 0.0f;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while getting the color point: {ex.Message}", ex);
            }
        }

        public ElementColor? GetElementColorById(string element, string color)
        {
            return context.ElementColors.SingleOrDefault(ec => ec.ElementId == element && ec.ColorId == color);
        }
    }
}
