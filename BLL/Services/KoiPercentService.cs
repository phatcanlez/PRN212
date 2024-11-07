using DAL;
using DAL.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class KoiPercentService
    {
        private Swp391FengShuiKoiConsultingDbContext context = new Swp391FengShuiKoiConsultingDbContext();
        public List<TypeColor> getKoiPercent(string koiType)
        {
            List<TypeColor> allType = context.TypeColors.ToList();
            return allType.Where(item => item.KoiType == koiType).ToList();
        }
    }
}
