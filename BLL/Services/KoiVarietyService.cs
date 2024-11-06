using DAL.Entities;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class KoiVarietyService
    {
        private KoiVarietyRepository koiVarietyRepository = new();

        public List<KoiVariety> GetKoiVarieties()
        {
            return koiVarietyRepository.GetAll();
        }

        public List<KoiVariety> filterKoisByName(String name,String element)
        {
            return koiVarietyRepository.GetAll().Where(koi => koi.Element.Equals(element) && koi.KoiType.ToLower().Contains(name)).ToList();
        }

        public List<KoiVariety> filterKoisByElement(String element)
        {
            return koiVarietyRepository.GetAll().Where(koi => koi.Element.Equals(element)).ToList();
        }
    }
}
