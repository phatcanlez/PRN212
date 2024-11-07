using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ShapeRepository
    {
        private Swp391FengShuiKoiConsultingDbContext context;

        public List<Shape> GetAll()
        {
            context = new Swp391FengShuiKoiConsultingDbContext();
            return context.Shapes.ToList();
        }

    }
}
