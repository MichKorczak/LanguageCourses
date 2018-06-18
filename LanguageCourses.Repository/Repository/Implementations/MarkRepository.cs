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
    public class MarkRepository : IMarkRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public MarkRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Mark>> GetMarkListAsync() =>
            await _applicationDbContext.Marks.ToListAsync();

        public async Task<List<Mark>> GetMarkByCourseUserListAsync(Guid courseUserId) =>
            await _applicationDbContext.Marks.Where(t => t.CourseUserId == courseUserId).ToListAsync();

        public async Task<Mark> GetMarkById(Guid id) =>
            await _applicationDbContext.Marks.FirstOrDefaultAsync(t => t.Id == id);

        public async Task AddMarkAsync(Mark courseUserMark) => 
            await _applicationDbContext.Marks.AddAsync(courseUserMark);

        public void DeleteMarkAsync(Mark courseUserMark) =>
            _applicationDbContext.Marks.Remove(courseUserMark);

        public async Task<bool> SaveChanges() => await _applicationDbContext.SaveChangesAsync() >= 0;
    }
}
