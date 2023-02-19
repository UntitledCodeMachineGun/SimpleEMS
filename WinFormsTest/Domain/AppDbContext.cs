using System.Data.SqlClient;
using WinFormsTest.Models;
using WinFormsTest.Models.Abstract;

namespace WinFormsTest.Domain
{
    public class AppDbContext
    {
        private static string _connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=GoodCompany; User Id=sa; Password=sa";
        public SqlConnection SqlConnection = new SqlConnection(_connectionString);
        public SqlCommand Cmd;
        public SqlDataReader Reader;

        /// <summary>
        /// Saving Employee to DB
        /// </summary>
        /// <param name="employee">employee entity</param>
        /// <param name="mode">true if new record, false if update old</param>
        public void SaveEmployee(Employee employee, bool mode)
        {
            string sql;
            string msg;

            switch (mode)
            {
                case (true):
                    sql = $"insert into Employees(Name, Surname, FatherName, Address," +
                    " Phone, DateOfBirth, DateOfHire, Salary, DeptId, PosId) " +
                    "values(@Name, @Surname, @FatherName, @Address, @Phone, @DateOfBirth, @DateOfHire, @Salary, " +
                    "@DeptId, @PosId)";

                    msg = "Added!";
                    break;
                case (false):
                    sql = "update Employees set Name = @Name, Surname = @Surname, FatherName = @FatherName, Address = @Address," +
                    " Phone = @Phone, DateOfBirth = @DateOfBirth, DateOfHire = @DateOfHire, Salary = @Salary, DeptId = @DeptId, PosId = @PosId " +
                    $"where Id = {employee.Id}";

                    msg = "Updated!";
                    break;
            }

            SqlConnection.Open();
            Cmd = new SqlCommand(sql, SqlConnection);
            Cmd.Parameters.AddWithValue("@Name", employee.Name);
            Cmd.Parameters.AddWithValue("@Surname", employee.Surname);
            Cmd.Parameters.AddWithValue("@FatherName", employee.FatherName);
            Cmd.Parameters.AddWithValue("@Address", employee.Address);
            Cmd.Parameters.AddWithValue("@Phone", employee.Phone);
            Cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
            Cmd.Parameters.AddWithValue("@DateOfHire", employee.DateOfHire);
            Cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            Cmd.Parameters.AddWithValue("@DeptId", employee.DeptId);
            Cmd.Parameters.AddWithValue("@PosId", employee.PosId);
            Cmd.ExecuteNonQuery();
            MessageBox.Show(msg);
            SqlConnection.Close();
        }

        public void Save(ISingleEntity entity, string tableName)
        {
            SqlConnection.Open();
            Cmd = new SqlCommand($"insert into {tableName}(Name) values(@Name)", SqlConnection);
            Cmd.Parameters.AddWithValue("@Name", entity.Name);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Added!");
            SqlConnection.Close();
        }

        public Dictionary<string, string> GetAllNames(string tableName)
        {
            Cmd = new SqlCommand($"select * from {tableName}", SqlConnection);
            SqlConnection.Open();
            Reader = Cmd.ExecuteReader();
            var entities = new Dictionary<string, string>();
            while (Reader.Read())
            {
                entities.Add(Reader["Id"].ToString(), Reader["Name"].ToString());
            }
            return entities;
        }
    }
}
