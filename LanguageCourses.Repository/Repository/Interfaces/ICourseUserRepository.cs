using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Repository.Repository.Interfaces
{
    public interface ICourseUserRepository
    {
        Task<List<CourseUser>> GetCourseUserListAsync();

        Task<List<Course>> GetCouseUserByCourseListAsync(Guid courseId);

        Task<List<User>> GetCouseUserByUserListAsync(Guid userId);

        Task<CourseUser> GetCourseUserById(Guid id);

        Task AddCouseUserAsync(CourseUser courseUser);

        void DeleteCourseAsync(CourseUser courseUser);

        Task<bool> SaveChanges();
    }
}
