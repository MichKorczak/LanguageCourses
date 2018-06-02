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
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CourseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Course>> GetCourseListAsync() 
        {
            var user = await _applicationDbContext.Courses.ToListAsync();
            return user;
        }

        public async Task<Course> GetCourseById(Guid courseId)
        {
            var user = await _applicationDbContext.Courses.FirstOrDefaultAsync(t => t.Id == courseId);
            return user;
        }

        public async Task<List<Course>> GetCourseByLanguage(string language)
        {
            var user = await _applicationDbContext.Courses.Where(t => t.Language == language).ToListAsync();
            return user;
        }

        public async Task<List<Course>> GetCourseByCourseLevel(int courseLevel)
        {
            var user = await _applicationDbContext.Courses.Where(t => t.CourseLevel == courseLevel).ToListAsync();
            return user;
        }

        public async Task AddCourseAsync(Course course)
        {
            await _applicationDbContext.Courses.AddAsync(course);
        }

        public void DeleteCourseAsync(Course course)
        {
            _applicationDbContext.Courses.Remove(course);
        }

        public async Task<bool> SaveChanges()
        {
            return await _applicationDbContext.SaveChangesAsync() >= 0;
        }
    }
}

