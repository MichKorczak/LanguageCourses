using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Repository.Repository.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCourseListAsync();

        Task<Course> GetCourseById(Guid courseId);

        Task<List<Course>> GetCourseByLanguage(string language);

        Task<List<Course>> GetCourseByCourseLevel(int courseLevel);

        Task AddCourseAsync(Course course);

        void DeleteCourseAsync(Course course);

        Task<bool> SaveChanges();
    }
}
