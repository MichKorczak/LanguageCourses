using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.Model;
using LanguageCourses.Repository.Repository.Interfaces;

namespace LanguageCourses.Repository.Repository.Implementations
{
    public class CourseUserMarkRepository : ICourseUserMarkRepository
    {
        public Task<List<CourseUserMark>> GetCourseUserMarkListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseUserMark>> GetCouseUserMarkByCourseUserListAsync(Guid courseUserId)
        {
            throw new NotImplementedException();
        }

        public Task<CourseUserMark> GetCourseUserMarkById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddCouseUserMarkAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteCourseAsync(CourseUserMark courseUserMark)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
