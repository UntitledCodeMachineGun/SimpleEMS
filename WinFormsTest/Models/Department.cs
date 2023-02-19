using WinFormsTest.Models.Abstract;

namespace WinFormsTest.Models
{
    public class Department : ModelBase, ISingleEntity
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
