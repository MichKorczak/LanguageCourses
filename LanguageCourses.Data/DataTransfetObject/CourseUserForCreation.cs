using System;
using System.ComponentModel.DataAnnotations;

namespace LanguageCourses.Data.DataTransfetObject
{
    public class CourseUserForCreation
    {
        [Required] public Guid CourseId { get; set; }

        [Required] public Guid UserId { get; set; }
    }
}