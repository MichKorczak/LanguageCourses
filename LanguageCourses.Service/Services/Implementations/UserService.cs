using System.Threading.Tasks;
using AutoMapper;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;
using LanguageCourses.Repository.Repository.Interfaces;
using LanguageCourses.Service.Services.Interfaces;
using LanguageCourses.Services.Services.Interfaces;

namespace LanguageCourses.Service.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHashService _hashService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IHashService hashService, ITokenService tokenService, IMapper mapper)
        {
            _userRepository = userRepository;
            _hashService = hashService;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            var userEmail = await _userRepository.GetUserByEmail(user.Email);
            var userLogin = await _userRepository.GetUserByName(user.Login);
            if (userLogin != null || userEmail != null)
                return false;

            user.Salt = _hashService.CreatedSalt();
            user.Password = _hashService.HashPassword(user.Password, user.Salt);

            await _userRepository.AddUserAsync(user);
            return await _userRepository.SaveChanges();
        }

        public async Task<TokenModel> GetToken(UserForLogin userForLogin)
        {
            var user = await _userRepository.GetUserByName(userForLogin.Login);
            if (user == null)
                return null;
            userForLogin.Password = _hashService.HashPassword(userForLogin.Password, user.Salt);
            if (user.Password.Equals(userForLogin.Password))
                return _tokenService.CreateToken(user);
            return null;
        }
    }
}
