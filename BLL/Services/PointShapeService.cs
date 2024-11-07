using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{

    public class PointShapeService
    {
        private Swp391FengShuiKoiConsultingDbContext _context = new Swp391FengShuiKoiConsultingDbContext();
        public PointOfShape? GetPointOfShape(string element, string shape)
        {
            return _context.PointOfShapes.FirstOrDefault(p => p.ElementId == element && p.ShapeId == shape);
        }
    }
}
