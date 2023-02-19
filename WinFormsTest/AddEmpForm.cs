using WinFormsTest.Domain.Concrete;
using WinFormsTest.Models;

namespace WinFormsTest
{
    public partial class AddEmpForm : Form
    {
        public AddEmpForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeRepository repository = new EmployeeRepository();
                var employee = new Employee()
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    FatherName = FathernameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    DateOfBirth = BirthDatePicker.Value,
                    DateOfHire = HireDatePicker.Value,
                    Salary = Convert.ToInt32(SalaryTextBox.Text),
                    DeptId = Convert.ToInt32(DeptComboBox.SelectedValue),
                    PosId = Convert.ToInt32(PosComboBox.SelectedValue),

                };
                repository.Save(employee);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Fill missing fields!\n" + ex);
            }
            Close();
        }

        private void AddEmpForm_Load(object sender, EventArgs e)
        {
            DepartmentRepository drepository = new DepartmentRepository();
            PositionRepository prepository = new PositionRepository();

            DeptComboBox.DataSource = new BindingSource(drepository.GetDepartments(), null);
            DeptComboBox.DisplayMember = "Value";
            DeptComboBox.ValueMember = "Key";

            PosComboBox.DataSource = new BindingSource(prepository.GetPositions(), null);
            PosComboBox.DisplayMember = "Value";
            PosComboBox.ValueMember = "Key";
        }
    }
}
