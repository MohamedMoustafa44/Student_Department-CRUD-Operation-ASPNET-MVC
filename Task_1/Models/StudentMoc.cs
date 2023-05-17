namespace Task_1.Models
{
    public class StudentMoc
    {
        static List<Student> students = new List<Student>()
        {
            new Student()
            {
                StdId = 1,
                StdName = "Mohamed Moustafa",
                Age = 24,
            },
            new Student()
            {
                StdId = 2,
                StdName = "Marwan Moustafa",
                Age = 21,
            },
            new Student()
            {
                StdId = 3,
                StdName = "Hassan Kassem",
                Age = 24,
            }
        };

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public void AddStudent(Student std)
        {
            students.Add(std);
        }

        public Student GetStudentById(int StdId)
        {
            return students.FirstOrDefault(stdObj => stdObj.StdId == StdId);
        }
        public void RemoveStudent(int id)
        {
            Student std = students.FirstOrDefault(a => a.StdId == id);
            students.Remove(std);
        }
        public void UpdateStudent(Student std)
        {
            Student oldStd = students.FirstOrDefault(stdObj => stdObj.StdId == std.StdId);
            oldStd.StdName = std.StdName;
            oldStd.Age = std.Age;
        }
    }
}
