using Microsoft.AspNetCore.Mvc;
using SchoolProject.Services;
using SchoolProject.Utilities;
using SchoolProject.ViewModels;

namespace SchoolProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GradesController : Controller
    {
        private IGradeService _gradeServiece;

        public GradesController(IGradeService gradeServiece)
        {
            _gradeServiece = gradeServiece;
        }

        public IActionResult Index(int pageNumber=1, int pageSize=10)
        {
            PagedResult<GradeViewModel> grade = _gradeServiece.GetAll(pageNumber, pageSize);
            return View();
        }
        [HttpGet]
        public IActionResult AddGrade()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGrade(CreateGradeViewModel vm)
        {
            await _gradeServiece.Add(vm);
            return RedirectToAction("Index");
        }
    }
}
