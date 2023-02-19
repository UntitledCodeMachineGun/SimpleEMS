namespace WinFormsTest.Models
{
    public class Employee : ModelBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfHire { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }
        public int PosId { get; set; }
    }
}
