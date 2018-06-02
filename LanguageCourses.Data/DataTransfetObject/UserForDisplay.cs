using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class UserForDisplay
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DataType DateOfBirthday { get; set; }
    }
}