using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KoiVarietyRepository
    {

        private  Swp391FengShuiKoiConsultingDbContext _context;

        public List<KoiVariety> GetAll()
        {
            _context = new();
            return _context.KoiVarieties.ToList();
        }
    }
}
