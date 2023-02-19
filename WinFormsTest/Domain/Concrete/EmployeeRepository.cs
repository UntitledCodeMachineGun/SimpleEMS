using System.Data.SqlClient;
using WinFormsTest.Domain.Abstract;
using WinFormsTest.Models;

namespace WinFormsTest.Domain.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context = new AppDbContext();

        public EmployeeRepository() { }

        public void Save(Employee employee)
        {

            if (context.Mode == true)
            {
               var sql = "insert into Employees(Name, Surname, FatherName, Address," +
                    " Phone, DateOfBirth, DateOfHire, Salary, DeptId, PosId) " +
                    "values(@Name, @Surname, @FatherName, @Address, @Phone, @DateOfBirth, @DateOfHire, @Salary, " +
                    "@DeptId, @PosId)";

                context.SqlConnection.Open();
                context.Cmd = new SqlCommand(sql, context.SqlConnection);
                context.Cmd.Parameters.AddWithValue("@Name", employee.Name);
                context.Cmd.Parameters.AddWithValue("@Surname", employee.Surname);
                context.Cmd.Parameters.AddWithValue("@FatherName", employee.FatherName);
                context.Cmd.Parameters.AddWithValue("@Address", employee.Address);
                context.Cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                context.Cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                context.Cmd.Parameters.AddWithValue("@DateOfHire", employee.DateOfHire);
                context.Cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                context.Cmd.Parameters.AddWithValue("@DeptId", employee.DeptId);
                context.Cmd.Parameters.AddWithValue("@PosId", employee.PosId);
                context.Cmd.ExecuteNonQuery();
                MessageBox.Show("Added!");
                context.SqlConnection.Close();
            }
            else
            { 
                
            }
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
    }
}
