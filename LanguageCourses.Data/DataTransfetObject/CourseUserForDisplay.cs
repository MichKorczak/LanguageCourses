using System;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseUserForDisplay
    {
        public Guid CourseId { get; set; }

        public Guid UserId { get; set; }

        public decimal Marks { get; set; }
    }
}