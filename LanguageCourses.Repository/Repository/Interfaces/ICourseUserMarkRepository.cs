using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Repository.Repository.Interfaces
{
    public interface ICourseUserMarkRepository
    {
        Task<List<CourseUserMark>> GetCourseUserMarkListAsync();

        Task<List<CourseUserMark>> GetCouseUserMarkByCourseUserListAsync(Guid courseUserId);

        Task<CourseUserMark> GetCourseUserMarkById(Guid id);

        Task AddCouseUserMarkAsync();

        Task<int> DeleteCourseAsync(CourseUserMark courseUserMark);

        Task<bool> SaveChanges();
    }
}
