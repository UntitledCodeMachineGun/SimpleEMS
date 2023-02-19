using WinFormsTest.Domain.Concrete;

namespace WinFormsTest
{
    public partial class EmployeesViewForm : Form
    {
        public EmployeesViewForm()
        {
            InitializeComponent();
            EmployeeRepository repository = new EmployeeRepository();
            repository.Load(EmpGridView);
        }
    }
}
