using System.Data.SqlClient;
using WinFormsTest.Domain.Abstract;
using WinFormsTest.Models;

namespace WinFormsTest.Domain.Concrete
{
    internal class TextFieldRepository : ITextFieldRepository
    {
        AppDbContext context = new AppDbContext();
        /// <summary>
        /// Saving of Text field
        /// </summary>
        /// <param name="name">Title</param>
        /// <param name="text">Main text</param>
        /// <param name="mode">True if insert, false if update</param>
        public void Save(string name, string text, bool mode)
        {
            context.SqlConnection.Open();
            string msg;
            switch (mode)
            {
                case true:
                    context.Cmd = new SqlCommand($"insert into TextFields (Name, Text) values('{name}', '{text}')", context.SqlConnection);
                    msg = "Added!";
                    break;
                case false:
                    context.Cmd = new SqlCommand($"update TextFields set Name = '{name}', Text = '{text}'", context.SqlConnection);
                    msg = "Updated!";
                    break;
            }

            context.Cmd.ExecuteNonQuery();
            MessageBox.Show(msg);
            context.SqlConnection.Close();
        }

        /// <summary>
        /// Getting text from TextField table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TextField GetTextField(string id)
        {
            context.Cmd = new SqlCommand($"select * from TextFields where Id = {id}", context.SqlConnection);
            context.SqlConnection.Open();
            context.Reader = context.Cmd.ExecuteReader();
            var field = new TextField();
            while (context.Reader.Read())
            {
                if (context.Reader["Id"] != null)
                {
                    field.Name = context.Reader["Name"].ToString();
                    field.Text = context.Reader["Text"].ToString();
                }
            }
            context.SqlConnection.Close();
            return field;
        }
    }
}
