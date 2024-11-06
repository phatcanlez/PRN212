using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Util
{
    public class LifePalaceCalculator
    {

        public string GetLifePalacetByBirthYear(string dob, string gender)
        {
            int year = int.Parse(dob.Substring(0, 4));
            try
            {
                var lifePalace = CalculateFate(year,gender);
                return lifePalace;
            }
            catch (Exception ex)
            {
                return "Định dạng ngày tháng năm không hợp lệ";
            }
        }
        public string CalculateFate(int birthYear, string Gender)
        {
            int sum = 0;
            while (birthYear > 0)
            {
                sum += birthYear % 10;
                birthYear /= 10;
            }
            int result = sum % 9;
            if (result == 0) result = 9;

            string[] maleFates = { "", "Khảm", "Ly", "Cấn", "Đoài", "Càn", "Khôn", "Tốn", "Chấn", "Khôn" };
            string[] femaleFates = { "", "Cấn", "Càn", "Đoài", "Cấn", "Ly", "Khảm", "Khôn", "Chấn", "Tốn" };

            if (Gender.Equals("Male"))
            {
                return maleFates[result];
            }
            else
            {
                return femaleFates[result];
            }
        }
    }
}

