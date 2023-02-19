using System.Data.SqlClient;
using WinFormsTest.Domain.Abstract;
using WinFormsTest.Models;

namespace WinFormsTest.Domain.Concrete
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context = new AppDbContext();
        public DepartmentRepository(){ }

        public void Save(Department department)
        {
            context.Save(department, "Departments");
        }

        public Dictionary<string, string> GetDepartments()
        {
            return context.GetAllNames("Departments");
        }
    }
}
