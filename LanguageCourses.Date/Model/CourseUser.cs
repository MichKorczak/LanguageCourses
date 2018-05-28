using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageCourses.Date.Model
{
    public class CourseUser
    {
        [Key]
        public Guid Id { get; set; }

        public ICollection<decimal> Marks { get; set; }

        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
    }
}
