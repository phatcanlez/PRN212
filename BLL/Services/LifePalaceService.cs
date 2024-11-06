using BLL.Util;
using DAL.Entities;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LifePalaceService
    {
        private LifePalaceCalculator lifePalaceCalculator = new();

        public String CalculateFate(string yearOfBirth, string gender)
        {
            return lifePalaceCalculator.GetLifePalacetByBirthYear(yearOfBirth, gender);
        }
    }
}
