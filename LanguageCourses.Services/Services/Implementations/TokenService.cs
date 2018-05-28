using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LanguageCourses.Date.Model;
using LanguageCourses.Services.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace LanguageCourses.Services.Services.Implementations
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration configuration;

        public TokenService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public TokenModel CreateToken(User user)
        {
            var claimsdata = new[] { new Claim(ClaimTypes.Name, user.Login) };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenKey = new JwtSecurityToken(
                issuer: configuration["Token:Issuer"],
                audience: configuration["Token:Issuer"],
                expires: DateTime.Now.AddMinutes(30),
                claims: claimsdata,
                signingCredentials: credentials);

            var resoultToken = new TokenModel
            {
                Token = new JwtSecurityTokenHandler().WriteToken(tokenKey),
                Email = user.Email,
                UserId = user.Id.ToString()
            };

            return resoultToken;
        }
    }
}
