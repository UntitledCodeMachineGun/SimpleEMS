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

        /// <summary>
        /// Delete record
        /// </summary>
        /// <param name="id">Id of record</param>
        /// <param name="tableName">Name of table</param>
        public void Delete(string id, string tableName)
        { 
            SqlConnection.Open();
            Cmd = new SqlCommand($"delete from {tableName} where Id = {id}", SqlConnection);
            Cmd.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Deleted!");
        }

        /// <summary>
        /// Saving for single string fields, like Department or Positon
        /// </summary>
        /// <param name="entity">ISingleEntity object</param>
        /// <param name="tableName">Name of table</param>
        public void Save(ISingleEntity entity, string tableName)
        {
            if (IsExists(entity, tableName))
            {
                MessageBox.Show($"{entity.Name} is already exists!");
            }
            else
            {
                SqlConnection.Open();
                Cmd = new SqlCommand($"insert into {tableName}(Name) values(N'{entity.Name}')", SqlConnection);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Added!");
                SqlConnection.Close();
            }
        }

        /// <summary>
        /// Is department or position is exists
        /// </summary>
        /// <param name="entity">ISingleEntity object</param>
        /// <param name="tableName">Name of table</param>
        /// <returns></returns>
        public bool IsExists(ISingleEntity entity, string tableName)
        {
            bool exists = false;

            SqlConnection.Open();
            Cmd = new SqlCommand($"select Name from {tableName} where Name = N'{entity.Name}'", SqlConnection);
            Reader = Cmd.ExecuteReader();
            while (Reader.Read())
            {
                if (Reader[0].ToString() == entity.Name)
                {
                    exists = true;
                }
            }
            SqlConnection.Close();
            
             return exists;
        }

        /// <summary>
        /// Getting Id and Name of items
        /// </summary>
        /// <param name="tableName">Name of table</param>
        /// <returns></returns>
        public Dictionary<string, string> GetAllNames(string tableName)
        {
            Cmd = new SqlCommand($"select Id, Name from {tableName}", SqlConnection);
            SqlConnection.Open();
            Reader = Cmd.ExecuteReader();
            var entities = new Dictionary<string, string>();
            while (Reader.Read())
            {
                if (Reader["Id"] != null)
                {
                    entities.Add(Reader["Id"].ToString(), Reader["Name"].ToString());
                }
            }
            SqlConnection.Close();
            return entities;
        }
        /// <summary>
        /// Get strings of single column
        /// </summary>
        /// <param name="tableName">Name of table</param>
        /// <param name="columnName">Name of column</param>
        /// <returns></returns>
        public List<string> GetStrings(string tableName, string columnName)
        {
            Cmd = new SqlCommand($"select distinct {columnName} from {tableName}", SqlConnection);
            SqlConnection.Open();
            Reader = Cmd.ExecuteReader();
            var entities = new List<string>();
            while (Reader.Read())
            {
                if (Reader[0] != null)
                {
                    entities.Add(Reader[0].ToString());
                }
            }
            SqlConnection.Close();
            return entities;
        }
    }
}
