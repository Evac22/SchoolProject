using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolProject.Services;
using SchoolProject.ViewModels;

namespace SchoolProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private IGradeService _gradeService;
        private ISessionService _sessionService;

        public StudentController(IStudentService studentService, 
            ISessionService sessionService, 
            IGradeService gradeService)
        {
            _studentService = studentService;
            _gradeService = gradeService;
            _sessionService = sessionService;
        }

        public IActionResult Index(int pageNumber=1, int pageSize=10)
        {
            ViewBag.Grades = new SelectList(_gradeService.GetAll(), "Id", "Name");
            ViewBag.session = new SelectList(_sessionService.GetAll(), "Id", "Combined");

            var students = _studentService.GetAll(pageNumber, pageSize);
            return View(students);
        }
        [HttpGet]
        public async Task<IActionResult> AddStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(CreateStudentViewModel vm)
        {
            await _studentService.AddStudent(vm);
            return RedirectToAction("Index");
        }
    }
}
