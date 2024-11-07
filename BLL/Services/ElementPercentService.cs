using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    
    public class ElementPercentService
    {
        private Swp391FengShuiKoiConsultingDbContext context = new Swp391FengShuiKoiConsultingDbContext();

        public List<ElementColor> getElementPercent()
        {
            return context.ElementColors.Distinct().ToList();
        }
    }
}
