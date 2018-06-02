using LanguageCourses.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace LanguageCourses.Data.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CourseUser> CourseUsers { get; set; }
        public DbSet<CourseUserMark> CourseUserMarks { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}