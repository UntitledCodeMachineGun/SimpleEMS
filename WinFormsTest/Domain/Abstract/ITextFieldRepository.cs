using WinFormsTest.Models;

namespace WinFormsTest.Domain.Abstract
{
    internal interface ITextFieldRepository
    {
        public void Save(string name, string text, bool mode);
        public TextField GetTextField(string id);
    }
}
