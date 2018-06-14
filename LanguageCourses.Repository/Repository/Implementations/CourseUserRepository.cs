using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageCourses.Data.DataAccessLayer;
using LanguageCourses.Data.Model;
using LanguageCourses.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanguageCourses.Repository.Repository.Implementations
{
    public class CourseUserRepository : ICourseUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CourseUserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<CourseUser>> GetCourseUserListAsync() =>await _applicationDbContext.CourseUsers.ToListAsync();

        public async Task<List<Course>> GetCouseUserByCourseListAsync(Guid courseId) =>
            await _applicationDbContext.Courses.Where(t => t.Id == courseId).ToListAsync();

        public async Task<List<User>> GetCouseUserByUserListAsync(Guid userId) =>
            await _applicationDbContext.Users.Where(t => t.Id == userId).ToListAsync();

        public async Task<CourseUser> GetCourseUserById(Guid id) =>
            await _applicationDbContext.CourseUsers.FirstOrDefaultAsync(t => t.Id == id);

        public async Task AddCouseUserAsync(CourseUser courseUser) =>
            await _applicationDbContext.CourseUsers.AddAsync(courseUser);

        public void DeleteCourseAsync(CourseUser courseUser) => _applicationDbContext.CourseUsers.Remove(courseUser);

        public async Task<bool> SaveChanges() => await _applicationDbContext.SaveChangesAsync() >= 0;
    }
}
