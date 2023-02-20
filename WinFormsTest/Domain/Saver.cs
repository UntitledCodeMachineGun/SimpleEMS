using System.Data;

namespace WinFormsTest.Domain
{
    public class Saver
    {
        public void SaveToTxt(DataTable dataTable, string fileName)
        {
            string myTableAsString =
                string.Join(Environment.NewLine, dataTable.Rows.Cast<DataRow>().
                Select(r => r.ItemArray).ToArray().
                Select(x => string.Join("\t", x)));
            using (StreamWriter sw = new StreamWriter($"{fileName}.txt", false))
            {
                sw.WriteLine(myTableAsString);
            }
            MessageBox.Show("Saved!");
        }
    }
}
