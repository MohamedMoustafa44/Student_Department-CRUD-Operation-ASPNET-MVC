namespace Task_1.Models
{
    public class DepartmentMoc
    {
        static List<Department> departments = new List<Department>()
        {
            new Department()
            {
                DeptId = 1,
                DeptName = "PD",
                DeptManager = new Student()
                {
                    StdId = 1,
                    StdName = "Mohamed",
                    Age = 24,
                }
            },
            new Department()
            {
                DeptId = 2,
                DeptName = "OS",
                DeptManager = new Student()
                {
                    StdId = 2,
                    StdName = "Marwan",
                    Age = 21,
                }
            },
            new Department()
            {
                DeptId = 3,
                DeptName = "SA",
                DeptManager = new Student()
                {
                    StdId = 3,
                    StdName = "Hasan",
                    Age = 24,
                }
            },
        };

        public List<Department> ShowAllDepartments()
        {
            return departments;
        }

        public void AddDepartment(Department newDept)
        {
            departments.Add(newDept);
        }

        public Department GetDepartmentById(int id)
        {
            return departments.FirstOrDefault(deptObj => deptObj.DeptId == id);
        }

        public void DeleteDepartment(int id)
        {
            Department dept = departments.FirstOrDefault(deptObj => deptObj.DeptId == id);
            departments.Remove(dept);
        }

        public void UpdateDepartment(Department dept)
        {
            Department oldDept = departments.FirstOrDefault(deptObj => deptObj.DeptId == dept.DeptId);
            oldDept.DeptName = dept.DeptName;
            oldDept.DeptManager.StdName = dept.DeptManager.StdName;
        }
    }
}
