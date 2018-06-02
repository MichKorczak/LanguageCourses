using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddUserAsync(User user);

        Task<TokenModel> GetToken(UserForLogin forLogin);
    }
}