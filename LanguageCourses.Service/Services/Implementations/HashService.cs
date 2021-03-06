﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using LanguageCourses.Service.Services.Interfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace LanguageCourses.Service.Services.Implementations
{
    public class HashService : IHashService
    {
        public string HashPassword(string password, byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 32));
            return hashed;
        }

        public byte[] CreatedSalt()
        {
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
    }
}
