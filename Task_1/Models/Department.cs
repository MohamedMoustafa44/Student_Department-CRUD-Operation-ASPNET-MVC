namespace Task_1.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public Student DeptManager { get; set;}
    }
}
