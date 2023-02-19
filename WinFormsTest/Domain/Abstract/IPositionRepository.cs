using WinFormsTest.Models;

namespace WinFormsTest.Domain.Abstract
{
    public interface IPositionRepository
    {
        public void Save(Position position);
        public Dictionary<string, string> GetPositions();

    }
}
