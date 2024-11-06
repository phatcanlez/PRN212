using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Repository
{
    public class LifePalaceRepository
    {

        private  Swp391FengShuiKoiConsultingDbContext _context;

        public List<LifePalace> GetAll()
        {
            _context = new();
            return _context.LifePalaces.ToList();
        }

        

    }
}
