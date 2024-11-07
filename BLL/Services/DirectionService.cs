using DAL.Entities;
using DAL.Repository;

namespace BLL.Services
{
    public class DirectionService
    {
        DirectionRepository directionRepository = new();
        public List<Direction> GetDirections()
        {
            return directionRepository.GetAll();
        }
    }
}
