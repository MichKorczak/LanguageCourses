using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Repository.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByName(string login);

        Task<User> GetUserByEmail(string email);

        Task AddUserAsync(User user);

        Task<bool> SaveChanges();
    }
}
