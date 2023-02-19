using WinFormsTest.Domain.Concrete;
using WinFormsTest.Models;

namespace WinFormsTest
{
    public partial class AddNewDeptForm : Form
    {
        public AddNewDeptForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var dept = new Department(NameTextBox.Text);
            var repository = new DepartmentRepository();
            repository.Save(dept);
            Close();
        }
    }
}
