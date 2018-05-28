using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Date.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetCourseListAsync();

        Task<Course> GetCourseById(Guid courseId);

        Task<List<Course>> GetCourseByLanguage(string language);

        Task<List<Course>> GetCourseByCourseLevel(int courseLevel);

        Task AddCourseAsync(Course course);

        Task<int> DeleteCourseAsync(Course course);

        Task<bool> SaveChanges();
    }
}
