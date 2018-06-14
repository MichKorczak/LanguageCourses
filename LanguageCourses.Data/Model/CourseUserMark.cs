using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LanguageCourses.Data.Model
{
    public class CourseUserMark
    {
        [Key] public Guid Id { get; set; }

        [ForeignKey("CourseUser")] public Guid CourseUserId { get; set; }

        public decimal Mark { get; set; }
    }
}
