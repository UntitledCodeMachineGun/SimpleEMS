using WinFormsTest.Domain.Concrete;

namespace WinFormsTest
{
    public partial class EmployeesViewForm : Form
    {
        EmployeeRepository repository = new();
        public EmployeesViewForm()
        {
            InitializeComponent();
            repository.Load(EmpGridView);
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
        }
    }
}
