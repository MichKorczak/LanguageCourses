using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Repository.Repository.Interfaces
{
    public interface IMarkRepository
    {
        Task<List<Mark>> GetMarkListAsync();

        Task<List<Mark>> GetMarkByCourseUserListAsync(Guid courseUserId);

        Task<Mark> GetMarkById(Guid id);

        Task AddMarkAsync(Mark courseUserMark);

        void DeleteMarkAsync(Mark courseUserMark);

        Task<bool> SaveChanges();
    }
}
