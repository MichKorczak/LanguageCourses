using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseForDisplay
    {
        [Required] public string Email { get; set; }

        [Required] public string Login { get; set; }

        [Required] public string Password { get; set; }

        [Required] public string FirstName { get; set; }

        [Required] public string LastName { get; set; }

        [Required] public DataType DateOfBirthday { get; set; }
    }
}