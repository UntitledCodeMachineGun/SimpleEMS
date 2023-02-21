using System.Data;
using System.Data.SqlClient;

namespace WinFormsTest.Domain
{
    public class ReportCreator
    {
        private AppDbContext context = new AppDbContext();
        private Saver saver = new Saver();
        private DataGridView dataGrid { get; set; }

        public ReportCreator(DataGridView dataGrid) 
        {
            this.dataGrid = dataGrid;
        }

        public void CreateReportByDept()
        {
            var dataTable = new DataTable();
            using (context.SqlConnection)
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("select d.Name as Department, sum(e.Salary) as OverallSalary " +
                        "from Employees e inner join Departments d on e.DeptId = d.Id " +
                        "group by d.Name", context.SqlConnection))
                { 
                    adapter.Fill(dataTable);
                }
                saver.SaveToTxt(dataTable, "ReportByDept" + DateTime.Now.Millisecond);
                dataGrid.DataSource = dataTable;
            }
        }

        public void CreateReportByPos()
        {
            var dataTable = new DataTable();
            using (context.SqlConnection)
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("select p.Name as Position, sum(e.Salary) as OverallSalary " +
                        "from Employees e inner join Positions p on e.PosId = p.Id " +
                        "group by p.Name", context.SqlConnection))
                {
                    adapter.Fill(dataTable);
                }
                saver.SaveToTxt(dataTable, "ReportByPos" + DateTime.Now.Millisecond);
                dataGrid.DataSource = dataTable;
            }
        }

        public void CreateReportByAll()
        {
            var dataTable = new DataTable();
            using (context.SqlConnection)
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("select d.Name as Department, p.Name as Position, sum(e.Salary) as OverallSalary " +
                        "from Employees e inner join Positions p on e.PosId = p.Id " +
                        "inner join Departments d on e.DeptId = d.Id " +
                        "group by d.Name, p.Name", context.SqlConnection))
                {
                    adapter.Fill(dataTable);
                }
                saver.SaveToTxt(dataTable, "ReportByDeptAndPos" + DateTime.Now.Millisecond);
                dataGrid.DataSource = dataTable;
            }
        }
    }
}
