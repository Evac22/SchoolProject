using Microsoft.AspNetCore.Mvc;
using SchoolProject.ViewModels;

namespace SchoolProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddStudent()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> AddStudent(CreateStudentViewModel vm)
        //{
        //    await _studentService.AddStudent(vm);
        //    return RedirectToAction("Index");
        //}
    }
}
