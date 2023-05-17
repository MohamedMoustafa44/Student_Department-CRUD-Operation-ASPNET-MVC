using Microsoft.AspNetCore.Mvc;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentMoc DeptModel = new DepartmentMoc();
        public IActionResult Index()
        {
            
            return View(DeptModel.ShowAllDepartments());
        }

        public IActionResult AddNewDepartmentView()
        {
            return View();
        }

        public IActionResult AddNewDepartment(Department newDept)
        {
            DeptModel.AddDepartment(newDept);
            return RedirectToAction("Index");
        }

        public IActionResult DisplayDepartmentInfo(int id)
        {
            Department dept = DeptModel.GetDepartmentById(id);
            return View(dept);
        }

        [HttpGet]
        public IActionResult BeforeDeleteDepartment(int id)
        {
            Department dept = DeptModel.GetDepartmentById(id);
            return View(dept);
        }

        [HttpPost, ActionName("BeforeDeleteDepartment")]
        public IActionResult ConfirmDeleteDepartment(int id)
        {
            DeptModel.DeleteDepartment(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDepartmentInfo(int id)
        {
            Department dept = DeptModel.GetDepartmentById(id);
            return View(dept);
        }

        [HttpPost]
        public IActionResult UpdateDepartmentInfo(Department dept)
        {
            DeptModel.UpdateDepartment(dept);
            return RedirectToAction("Index");
        }
    }
}
