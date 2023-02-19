using WinFormsTest.Models.Abstract;

namespace WinFormsTest.Models
{
    public class Position : ModelBase, ISingleEntity
    {
        public string Name { get; set; }

        public Position(string name)
        {
            Name = name;
        }
    }
}
