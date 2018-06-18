using System.Threading.Tasks;
using LanguageCourses.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanguageCourses.MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> AllCourse()
        {
            var courseList = await _courseService.GetCourseListAsync();
            return View(courseList);
        }

    }
}
