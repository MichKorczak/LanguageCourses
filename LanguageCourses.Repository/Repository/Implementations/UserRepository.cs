using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.Data.DataAccessLayer;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;
using LanguageCourses.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanguageCourses.Repository.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IUserRepository _userRepository;

        public UserRepository(ApplicationDbContext applicationDbContext, IUserRepository userRepository)
        {
            _applicationDbContext = applicationDbContext;
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByName(string login)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(t => t.Login == login);
            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(t => t.Email == email);
            return user;
        }

        public async Task AddUserAsync(User user)
        {
            await _applicationDbContext.AddAsync(user);
        }

        public async Task<bool> SaveChanges()
        {
            return await _applicationDbContext.SaveChangesAsync() >= 0;
        }
    }
}
