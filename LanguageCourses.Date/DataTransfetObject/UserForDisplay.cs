using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanguageCourses.Date.DataTransfetObject
{
    public class UserForDisplay
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DataType DateOfBirthday { get; set; }
    }
}
