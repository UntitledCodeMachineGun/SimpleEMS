﻿using System.Data;
using System.Data.SqlClient;
using WinFormsTest.Domain.Abstract;
using WinFormsTest.Models;

namespace WinFormsTest.Domain.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context = new AppDbContext();

        public EmployeeRepository() { }
        /// <summary>
        /// Saving Employee to DB
        /// </summary>
        /// <param name="employee">employee entity</param>
        /// <param name="mode">true if new record, false if update old</param>
        public void Save(Employee employee, bool mode)
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
            MessageBox.Show(msg);
            context.SqlConnection.Close();
        }

        public void Delete(string id)
        {
            context.Delete(id, "Employees");
        }

        

        public void Load(DataGridView gridView)
        {
            try
            {
                var dataTable = new DataTable();

                context.SqlConnection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    "select e.Id, e.Name, e.Surname, e.FatherName, e.Address, e.Phone, e.DateOfBirth, e.DateOfHire, e.Salary, " +
                    "d.Name as Department, p.Name as Position, e.DeptId, e.PosId from Employees e left join Departments d on e.DeptId = d.Id left join Positions p on e.PosId = p.Id",
                    context.SqlConnection))
                {
                    adapter.Fill(dataTable);
                }
                gridView.DataSource = new DataView(dataTable);
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

        public List<string> GetNames()
        {
            return context.GetStrings("Employees", "Name");
        }

        public List<string> GetSurnames()
        {
            return context.GetStrings("Employees", "Surname");
        }

        public List<string> GetFatherNames()
        {
            return context.GetStrings("Employees", "FatherName");
        }
    }
}
