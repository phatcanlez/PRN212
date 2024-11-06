using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Repository
{
    public class ElementRepository
    {

        private  Swp391FengShuiKoiConsultingDbContext _context;

        public List<Element> GetAll()
        {
            _context = new();
            return _context.Elements.ToList();
        }

        

    }
}
