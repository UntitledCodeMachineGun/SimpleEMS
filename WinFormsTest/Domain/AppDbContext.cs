using System.Data.SqlClient;
using WinFormsTest.Models;
using WinFormsTest.Models.Abstract;

namespace WinFormsTest.Domain
{
    public class AppDbContext
    {
        private static string _connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=GoodCompany; User Id=sa; Password=sa";
        public SqlConnection SqlConnection = new SqlConnection(_connectionString);
        public SqlCommand Cmd;
        public SqlDataReader Reader;
        public bool Mode = true;
        public string Sql;


        public void Save(ISingleEntity entity, string tableName)
        {
            if (Mode == true)
            {
                Sql = $"insert into {tableName}(Name) values(@Name)";
                SqlConnection.Open();
                Cmd = new SqlCommand(Sql, SqlConnection);
                Cmd.Parameters.AddWithValue("@Name", entity.Name);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Added!");
                SqlConnection.Close();
            }
            else
            { 
                
            }
        }

        public Dictionary<string, string> GetAllNames(string tableName)
        {
            Cmd = new SqlCommand($"select * from {tableName}", SqlConnection);
            SqlConnection.Open();
            Reader = Cmd.ExecuteReader();
            var entities = new Dictionary<string, string>();
            while (Reader.Read())
            {
                entities.Add(Reader["Id"].ToString(), Reader["Name"].ToString());
            }
            return entities;
        }
    }
}
