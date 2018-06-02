using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseForDisplay>> GetCourseListAsync();

        Task<CourseForDisplay> GetCourseById(Guid courseId);

        Task<List<CourseForDisplay>> GetCourseByLanguage(string language);

        Task<List<CourseForDisplay>> GetCourseByCourseLevel(int courseLevel);

        Task<bool> AddCourseAsync(CourseForCreation courseForCreation);

        Task<bool> DeleteCourseAsync(Guid courseId);
    }
}