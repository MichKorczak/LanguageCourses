using System;
using System.Collections.Generic;
using System.Text;
using LanguageCourses.Date.Model;

namespace LanguageCourses.Services.Services.Interfaces
{
    public interface ITokenService
    {
        TokenModel CreateToken(User user);
    }
}
