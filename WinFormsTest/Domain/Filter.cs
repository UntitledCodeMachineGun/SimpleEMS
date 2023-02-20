using System.Data;

namespace WinFormsTest.Domain
{
    public class Filter
    {
        private string query = string.Empty;
        public Filter() {}

        /// <summary>
        /// Get filtered query by comboboxes
        /// </summary>
        /// <param name="Dept">Department box</param>
        /// <param name="Pos">Position box</param>
        /// <param name="Name">Name box</param>
        /// <param name="Surname">Surname box</param>
        /// <param name="FatherName">Surname box</param>
        /// <returns></returns>
        public string GetFilteredQuery(ComboBox Dept, ComboBox Pos, ComboBox Name, ComboBox Surname, ComboBox FatherName)
        {
            if (Dept.SelectedValue != null)
            {
                query += $"DeptId = '{Dept.SelectedValue}'";
            }
            if (Pos.SelectedValue != null)
            {
                AddAndToQueryIfNotEmpty();
                query += $"PosId = '{Pos.SelectedValue}'";
            }
            if (Name.SelectedValue != null)
            {
                AddAndToQueryIfNotEmpty();
                query += $"Name = '{Name.SelectedValue}'";
            }
            if (Surname.SelectedValue != null)
            {
                AddAndToQueryIfNotEmpty();
                query += $"Surname = '{Surname.SelectedValue}'";
            }
            if (FatherName.SelectedValue != null)
            {
                AddAndToQueryIfNotEmpty();
                query += $"FatherName = '{FatherName.SelectedValue}'";
            }

            return query;
        }

        private void AddAndToQueryIfNotEmpty()
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                query += " and ";
            }
        }
    }
}
