using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Service.Services.Interfaces
{
    public interface ICourseUserMarkService
    {
        Task<List<CourseUserMarkForDisplay>> GetCourseUserMarkListAsync();

        Task<List<CourseUserMarkForDisplay>> GetCouseUserMarkByCourseUserListAsync(Guid courseUserId);

        Task<CourseUserMarkForDisplay> GetCourseUserMarkById(Guid id);
            
        Task<bool> AddCouseUserMarkAsync(CourseUserMarkForCreation courseUserMarkForCreation);

        Task<bool> DeleteCourseUserMarkAsync(Guid courseUserMarkId);
    }
}
