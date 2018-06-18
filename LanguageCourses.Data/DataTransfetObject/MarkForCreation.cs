using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class MarkForCreation
    {
        [Required] public Guid CourseUserId { get; set; }

        [Required] public decimal Mark { get; set; }

        public string Description { get; set; }
    }
}
