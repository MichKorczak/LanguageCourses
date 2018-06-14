using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseUserForDisplay
    {
        public virtual ICollection<CourseUserMark> CourseUsersMarks { get; set; }

        public Guid CourseId { get; set; }

        public Guid UserId { get; set; }
    }
}