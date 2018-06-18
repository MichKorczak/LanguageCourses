using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Service.Services.Interfaces
{
    public interface IMarkService
    {
        Task<List<MarkForDisplay>> GetMarkListAsync();

        Task<List<MarkForDisplay>> GetMarkByCourseUserListAsync(Guid courseUserId);

        Task<MarkForDisplay> GetMarkById(Guid id);
            
        Task<bool> AddMarkAsync(MarkForCreation courseUserMarkForCreation);

        Task<bool> DeleteMarkAsync(Guid courseUserMarkId);
    }
}
