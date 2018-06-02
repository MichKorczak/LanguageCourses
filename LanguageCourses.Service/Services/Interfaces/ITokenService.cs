using LanguageCourses.Data.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface ITokenService
    {
        TokenModel CreateToken(User user);
    }
}