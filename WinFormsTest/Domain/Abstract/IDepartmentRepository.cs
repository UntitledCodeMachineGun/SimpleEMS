using WinFormsTest.Models;

namespace WinFormsTest.Domain.Abstract
{
    public interface IDepartmentRepository
    {
        public void Save(Department department);
        public Dictionary<string, string> GetDepartments();
    }
}
