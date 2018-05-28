﻿using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Date.Model
{
    public class TokenModel
    {
        public string Token { get; set; }
        public string Email { get; set; }

        [Key]
        public string UserId { get; set; }
    }
}
