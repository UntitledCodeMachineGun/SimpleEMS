using System.Data;
using WinFormsTest.Domain;
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
                var id = EmpGridView.CurrentRow.Cells[2].Value.ToString();
                var employee = repository.GetToEditEmployeeById(id);
                AddEmpForm addEmp = new(employee, id);
                addEmp.ShowDialog();
            }
            else if (e.ColumnIndex == EmpGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            { 
                 repository.Delete(EmpGridView.CurrentRow.Cells[2].Value.ToString());
            }
        }

        private void EmployeesViewForm_Activated(object sender, EventArgs e)
        {
            repository.Load(EmpGridView);
            EmpGridView.Columns["DeptId"].Visible = false;
            EmpGridView.Columns["PosId"].Visible = false;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)EmpGridView.DataSource;

            var filter = new Filter();

            dv.RowFilter = filter.GetFilteredQuery(FilterByDeptCombo, FilterByPosCombo,
                FilterByNameCombo, FilterBySurnameCombo, FilterByFatherCombo);
        }

        private void EmployeesViewForm_Load(object sender, EventArgs e)
        {
            var drepository = new DepartmentRepository();
            var prepository = new PositionRepository();
            var emplRepository = new EmployeeRepository();

            FilterByDeptCombo.DataSource = new BindingSource(drepository.GetDepartments(), null);
            FilterByDeptCombo.DisplayMember = "Value";
            FilterByDeptCombo.ValueMember = "Key";

            FilterByPosCombo.DataSource = new BindingSource(prepository.GetPositions(), null);
            FilterByPosCombo.DisplayMember = "Value";
            FilterByPosCombo.ValueMember = "Key";

            FilterByNameCombo.DataSource = new BindingSource(emplRepository.GetNames(), null);
            FilterByNameCombo.DisplayMember = "Value";
            FilterBySurnameCombo.DataSource = new BindingSource(emplRepository.GetSurnames(), null);
            FilterBySurnameCombo.DisplayMember = "Value";
            FilterByFatherCombo.DataSource = new BindingSource(emplRepository.GetFatherNames(), null);
            FilterByFatherCombo.DisplayMember = "Value";

            FilterByDeptCombo.SelectedItem = null;
            FilterByPosCombo.SelectedItem = null;
            FilterByNameCombo.SelectedItem = null;
            FilterBySurnameCombo.SelectedItem = null;
            FilterByFatherCombo.SelectedItem = null;
        }

        private void ClearFiltersBtn_Click(object sender, EventArgs e)
        {
            FilterByDeptCombo.SelectedItem = null;
            FilterByPosCombo.SelectedItem = null;
            FilterByNameCombo.SelectedItem = null;
            FilterBySurnameCombo.SelectedItem = null;
            FilterByFatherCombo.SelectedItem = null;
        }
    }
}
