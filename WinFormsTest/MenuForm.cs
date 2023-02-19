using System.Data.SqlClient;

namespace WinFormsTest
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ShowEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeesViewForm employeesView = new EmployeesViewForm();
            employeesView.ShowDialog();
        }

        private void AddNewEmpBtn_Click(object sender, EventArgs e)
        {
            AddEmpForm addEmp = new AddEmpForm(new Models.Employee());
            addEmp.ShowDialog();
        }

        private void AddNewDeptBtn_Click(object sender, EventArgs e)
        {
            AddNewDeptForm addDept = new AddNewDeptForm();
            addDept.ShowDialog();
        }

        private void AddNewPosBtn_Click(object sender, EventArgs e)
        {
            AddNewPosForm addPos = new AddNewPosForm();
            addPos.ShowDialog();
        }
    }
}