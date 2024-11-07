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
    public class LifePalaceDirectionService
    {
        private readonly Swp391FengShuiKoiConsultingDbContext _context = new Swp391FengShuiKoiConsultingDbContext();

        public LifePalaceDirection? GetLifePlaceDirectionById(string lifePalace, string direction)
        {
            return _context.LifePalaceDirections.SingleOrDefault(lpd => lpd.LifePalaceId == lifePalace && lpd.DirectionId == direction);
        }
    }
}
