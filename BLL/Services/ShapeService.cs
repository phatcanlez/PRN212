using DAL.Entities;
using DAL.Repository;

namespace BLL.Services
{
    public class ShapeService
    {
        ShapeRepository shapeRepository = new();
        public List<Shape> GetShapes()
        {
            return shapeRepository.GetAll();
        }
    }
}
