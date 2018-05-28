using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Date.DataTransfetObject
{
    public class CourseUserForAddMarks
    {
        [Required]
        public Guid CourseId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public decimal Marks { get; set; }
    }
}
