using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class UserForLogin
    {
        [Required] public string Login { get; set; }

        [Required] public string Password { get; set; }
    }
}