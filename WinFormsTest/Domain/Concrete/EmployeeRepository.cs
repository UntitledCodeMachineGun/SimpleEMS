using System.Data.SqlClient;
using WinFormsTest.Domain.Abstract;
using WinFormsTest.Models;

namespace WinFormsTest.Domain.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context = new AppDbContext();

        public EmployeeRepository() { }

        public void Save(Employee employee, bool mode)
        {
            context.SaveEmployee(employee, mode);
        }

        public void Load(DataGridView gridView)
        {
            try
            {
               var sql = "select * from Employees e left join Departments d on e.DeptId = d.Id left join Positions p on e.PosId = p.Id";
                context.Cmd = new SqlCommand(sql, context.SqlConnection);
                context.SqlConnection.Open();

                context.Reader = context.Cmd.ExecuteReader();
                gridView.Rows.Clear();

                while (context.Reader.Read())
                {
                    gridView.Rows.Add(context.Reader[0], context.Reader[1], context.Reader[2], context.Reader[3], context.Reader[4],
                        context.Reader[5], context.Reader[6], context.Reader[7], context.Reader[8], context.Reader[12], context.Reader[14]);
                }
                context.SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Employee GetToEditEmployeeById(string Id)
        {
            context.Cmd = new SqlCommand("select * from Employees where Id = '" + Id + "' ", context.SqlConnection);
            context.SqlConnection.Open();
            context.Reader = context.Cmd.ExecuteReader();
            var employee = new Employee();
            while (context.Reader.Read())
            {
                employee.Name = context.Reader.GetString(1);
                employee.Surname = context.Reader.GetString(2);
                employee.FatherName = context.Reader.GetString(3);
                employee.Address = context.Reader.GetString(4);
                employee.Phone = context.Reader.GetString(5);
                employee.DateOfBirth = context.Reader.GetDateTime(6);
                employee.DateOfHire = context.Reader.GetDateTime(7);
                employee.Salary = context.Reader.GetInt32(8);
                employee.DeptId = context.Reader.GetInt32(9);
                employee.PosId = context.Reader.GetInt32(10);
            }

            context.SqlConnection.Close();
            return employee;
        }
    }
}
