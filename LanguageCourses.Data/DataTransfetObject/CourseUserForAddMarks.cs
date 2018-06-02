using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseUserForAddMarks
    {
        [Required] public Guid CourseId { get; set; }

        [Required] public Guid UserId { get; set; }

        [Required] public decimal Marks { get; set; }
    }
}