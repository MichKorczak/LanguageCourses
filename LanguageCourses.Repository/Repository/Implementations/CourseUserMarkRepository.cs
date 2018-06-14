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
    public class CourseUserMarkRepository : ICourseUserMarkRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CourseUserMarkRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<CourseUserMark>> GetCourseUserMarkListAsync() =>
            await _applicationDbContext.CourseUserMarks.ToListAsync();

        public async Task<List<CourseUserMark>> GetCouseUserMarkByCourseUserListAsync(Guid courseUserId) =>
            await _applicationDbContext.CourseUserMarks.Where(t => t.CourseUserId == courseUserId).ToListAsync();

        public async Task<CourseUserMark> GetCourseUserMarkById(Guid id) =>
            await _applicationDbContext.CourseUserMarks.FirstOrDefaultAsync(t => t.Id == id);

        public async Task AddCouseUserMarkAsync(CourseUserMark courseUserMark) => 
            await _applicationDbContext.CourseUserMarks.AddAsync(courseUserMark);

        public void DeleteCourseAsync(CourseUserMark courseUserMark) =>
            _applicationDbContext.CourseUserMarks.Remove(courseUserMark);

        public async Task<bool> SaveChanges() => await _applicationDbContext.SaveChangesAsync() >= 0;
    }
}
