using WinFormsTest.Domain.Concrete;
using WinFormsTest.Models;

namespace WinFormsTest
{
    public partial class AddEmpForm : Form
    {
        public Employee Employee { get; set; }
        private bool _mode = true;

        public AddEmpForm(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }
        public AddEmpForm(Employee employee, string id)
        {
            Employee = employee;
            
            InitializeComponent();

            if (Employee.Name != null)
            {
                Employee.Id = Convert.ToInt32(id);
                NameTextBox.Text = Employee.Name;
                SurnameTextBox.Text = Employee.Surname;
                FathernameTextBox.Text = Employee.FatherName;
                AddressTextBox.Text = Employee.Address;
                PhoneTextBox.Text = Employee.Phone;
                BirthDatePicker.Value = Employee.DateOfBirth;
                HireDatePicker.Value = Employee.DateOfHire;
                SalaryTextBox.Text = Employee.Salary.ToString();
                DeptComboBox.SelectedValue = Employee.DeptId;
                PosComboBox.SelectedValue = Employee.PosId;
                _mode = false;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeRepository repository = new EmployeeRepository();

                Employee.Name = NameTextBox.Text;
                Employee.Surname = SurnameTextBox.Text;
                Employee.FatherName = FathernameTextBox.Text;
                Employee.Address = AddressTextBox.Text;
                Employee.Phone = PhoneTextBox.Text;
                Employee.DateOfBirth = BirthDatePicker.Value;
                Employee.DateOfHire = HireDatePicker.Value;
                Employee.Salary = Convert.ToInt32(SalaryTextBox.Text);
                Employee.DeptId = Convert.ToInt32(DeptComboBox.SelectedValue);
                Employee.PosId = Convert.ToInt32(PosComboBox.SelectedValue);

                repository.Save(Employee, _mode);
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
