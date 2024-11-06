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
    public class ElementService
    {
        private ElementRepository elementRepository = new();
        private ElementCalculator compatibilityCalculator = new();

        public String GetElementByBirthYear(string yearOfBirth)
        {
            return compatibilityCalculator.GetElementByBirthYear(yearOfBirth);
        }

        public List<Element> GetElements()
        {
            return elementRepository.GetAll().Select(e => new Element
            {
                ElementId = e.ElementId,
            }).ToList();
        }
    }
}
