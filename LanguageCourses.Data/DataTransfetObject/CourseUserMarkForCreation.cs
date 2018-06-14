using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseUserMarkForCreation
    {
        [Required] public Guid CourseUserId { get; set; }

        public decimal Mark { get; set; }
    }
}
