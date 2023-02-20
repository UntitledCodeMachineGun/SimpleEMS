using WinFormsTest.Domain.Concrete;

namespace WinFormsTest
{
    public partial class EmployeesViewForm : Form
    {
        private EmployeeRepository repository = new();
        public EmployeesViewForm()
        {
            InitializeComponent();
        }

        private void EmpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == EmpGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                var id = EmpGridView.CurrentRow.Cells[0].Value.ToString();
                var employee = repository.GetToEditEmployeeById(id);
                AddEmpForm addEmp = new(employee, id);
                addEmp.ShowDialog();
            }
            else if (e.ColumnIndex == EmpGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            { 
                 repository.Delete(EmpGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void EmployeesViewForm_Activated(object sender, EventArgs e)
        {
            repository.Load(EmpGridView);
        }
    }
}
