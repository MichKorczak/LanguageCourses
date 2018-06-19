using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseForDisplay
    {
        public Guid IdCourse { get; set; }

        public string Language { get; set; }

        public DateTime StartDate { get; set; }

        public int CourseLevel { get; set; }

        public int NumberOfSeats { get; set; }

        public string TeacherName { get; set; }
    }
}