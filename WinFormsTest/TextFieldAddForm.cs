using WinFormsTest.Domain.Concrete;
using WinFormsTest.Models;

namespace WinFormsTest
{
    public partial class TextFieldAddForm : Form
    {
        public TextField TextField { get; set; }
        private TextFieldRepository repository = new TextFieldRepository();
        private bool _mode = true;
        public TextFieldAddForm(TextField text)
        {
            InitializeComponent();

            TextField = text;

            if (TextField.Id == 0)
            { 
                NameTextBox.Text = TextField.Name.ToString();
                MainText.Text = TextField.Text.ToString();
                _mode = false;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            repository.Save(NameTextBox.Text, MainText.Text, _mode);
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MainText.Clear();
        }
    }
}
