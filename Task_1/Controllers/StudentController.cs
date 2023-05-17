using Microsoft.AspNetCore.Mvc;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class StudentController : Controller
    {
        StudentMoc StdModel = new StudentMoc();
        public IActionResult Index()
        {
            return View(StdModel.GetAllStudents());
        }

        public IActionResult AddStudentView()
        {
            return View();
        }

        public IActionResult DisplayStudentInfo(int id)
        {
            Student std = StdModel.GetStudentById(id);
            return View(std);
        }
        public IActionResult AddNewStudent(Student newStd)
        {
            StdModel.AddStudent(newStd);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BeforeDeleteStudent(int id)
        {
            Student std = StdModel.GetStudentById(id);
            return View(std);
        }

        [HttpPost, ActionName("BeforeDeleteStudent")]
        public IActionResult ConfirmDeleteStudent(int id)
        {
            StdModel.RemoveStudent(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudentInfo(int id)
        {
            Student std = StdModel.GetStudentById(id);
            return View(std);
        }

        [HttpPost]
        public IActionResult UpdateStudentInfo(Student std)
        {
            StdModel.UpdateStudent(std);
            return RedirectToAction("Index");
        }
    }
}
