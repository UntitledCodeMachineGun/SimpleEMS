using WinFormsTest.Domain.Concrete;
using WinFormsTest.Models;

namespace WinFormsTest
{
    public partial class MenuForm : Form
    {
        private TextFieldRepository textFieldRepository = new TextFieldRepository();
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

        private void CompanyInfoEditBtn_Click(object sender, EventArgs e)
        {
            TextFieldAddForm textFieldAdd = new TextFieldAddForm(textFieldRepository.GetTextField("1"));
            textFieldAdd.ShowDialog();
        }

        private void MenuForm_Activated(object sender, EventArgs e)
        {

            var text = textFieldRepository.GetTextField("1").Text;
            CompanyInfoTextBox.Text = text;
        }
    }
}