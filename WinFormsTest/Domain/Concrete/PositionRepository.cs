using WinFormsTest.Domain.Abstract;
using WinFormsTest.Models;

namespace WinFormsTest.Domain.Concrete
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AppDbContext context = new AppDbContext();
        public PositionRepository() { }

        public void Save(Position position)
        {
            context.Save(position, "Positions");
        }

        public Dictionary<string, string> GetPositions()
        {
            return context.GetAllNames("Positions");
        }
    }
}
