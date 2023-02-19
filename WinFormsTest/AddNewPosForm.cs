using WinFormsTest.Domain.Concrete;
using WinFormsTest.Models;

namespace WinFormsTest
{
    public partial class AddNewPosForm : Form
    {
        public AddNewPosForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var pos = new Position(NameTextBox.Text);
            var repository = new PositionRepository();
            repository.Save(pos);
            Close();
        }
    }
}
