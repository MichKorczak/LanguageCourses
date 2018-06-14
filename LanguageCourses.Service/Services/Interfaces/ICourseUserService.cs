using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface ICourseUserService
    {
        Task<List<CourseUser>> GetCourseUserListAsync();

        Task<List<CourseForDisplay>> GetCouseUserByCourseListAsync(Guid courseId);

        Task<List<UserForDisplay>> GetCouseUserByUserListAsync(Guid userId);

        Task<CourseUser> GetCourseUserById(Guid id);

        Task<bool> AddCouseUserAsync(CourseUserForCreation courseUser);

        Task<bool> DeleteCourseAsync(Guid courseUserId);
    }
}