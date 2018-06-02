using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseForCreation
    {
        [Required] public string Language { get; set; }

        [Required] public DateTime StartDate { get; set; }

        [Required] public int CourseLevel { get; set; }

        [Required] public int NumberOfSeats { get; set; }

        [Required] public string FirstNameTeacher { get; set; }

        [Required] public string LastNameTeacher { get; set; }
    }
}