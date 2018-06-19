using System.Collections.Generic;
using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
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
            if (courseList.Count == 0)
            {
                return View("Empty");
            }

            return View(courseList);
        }

        public IActionResult Update()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}
