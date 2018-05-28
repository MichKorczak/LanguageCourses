using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Date.DataTransfetObject
{
    public class CourseUserForUpdate
    {
        [Required]
        public Guid CourseId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public decimal Marks { get; set; }
    }
}
