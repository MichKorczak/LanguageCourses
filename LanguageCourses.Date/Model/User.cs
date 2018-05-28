using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanguageCourses.Date.Model
{
    public class User
    {
        [Key] public Guid Id { get; set; }

        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DataType DateOfBirthday { get; set; }

        public virtual ICollection<CourseUser> CourseUsers { get; set; }
    }
}
