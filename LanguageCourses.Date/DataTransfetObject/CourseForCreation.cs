using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanguageCourses.Date.DataTransfetObject
{
    public class CourseForCreation
    {
        [Required]
        public string Language { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int CourseLevel { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public string FirstNameTeacher { get; set; }

        [Required]
        public string LastNameTeacher { get; set; }
    }
}
