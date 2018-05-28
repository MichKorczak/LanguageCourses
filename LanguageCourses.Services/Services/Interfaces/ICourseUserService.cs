using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LanguageCourses.Date.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface ICourseUserService
    {
        Task<List<Course>> GetCourseUserListAsync();

        Task<Course> GetCourseUserById(Guid courseId);

        Task AddCourseUserAsync(Course course);

        Task AddMark(decimal mark);
            
        Task<int> DeleteCourseUserAsync(Course course);

        Task<bool> SaveChanges();
    }
}
