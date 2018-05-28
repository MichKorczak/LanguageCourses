using System.Threading.Tasks;
using LanguageCourses.Date.DataTransfetObject;
using LanguageCourses.Date.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddUserAsync(User user);

        Task<TokenModel> GetToken(UserForLogin forLogin);

        Task<bool> SaveChanges();
    }
}
