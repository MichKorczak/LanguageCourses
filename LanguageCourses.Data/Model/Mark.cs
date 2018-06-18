using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LanguageCourses.Data.Model
{
    public class Mark
    {
        [Key] public Guid Id { get; set; }

        [ForeignKey("CourseUser")] public Guid CourseUserId { get; set; }

        public decimal UserMark { get; set; }

        public string Description { get; set; }
    }
}
