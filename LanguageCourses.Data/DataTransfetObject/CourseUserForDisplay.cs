using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseUserForDisplay
    {
        public virtual ICollection<Mark> CourseUsersMarks { get; set; }

        public Guid CourseId { get; set; }

        public Guid UserId { get; set; }
    }
}