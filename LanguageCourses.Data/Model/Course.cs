using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.Model
{
    public class Course
    {
        [Key] public Guid Id { get; set; }

        public string Language { get; set; }
        public DateTime StartDate { get; set; }
        public int CourseLevel { get; set; }
        public int NumberOfSeats { get; set; }
        public string FirstNameTeacher { get; set; }
        public string LastNameTeacher { get; set; }

        public virtual ICollection<CourseUser> CourseUsers { get; set; }
    }
}