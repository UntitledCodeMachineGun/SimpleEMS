using WinFormsTest.Models;

namespace WinFormsTest.Domain.Abstract
{
    public interface IEmployeeRepository
    {
        public void Save(Employee employee);

        public void Load(DataGridView gridView);
    }
}
