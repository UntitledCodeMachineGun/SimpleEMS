using WinFormsTest.Models;

namespace WinFormsTest.Domain.Abstract
{
    public interface IEmployeeRepository
    {
        public void Save(Employee employee, bool Mode);
        public void Load(DataGridView gridView);
        public Employee GetToEditEmployeeById(string id);
        public void Delete(string id);
        public List<string> GetNames();
        public List<string> GetSurnames();
        public List<string> GetFatherNames();

    }
}
