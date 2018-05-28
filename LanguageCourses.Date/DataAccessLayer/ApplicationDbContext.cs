using LanguageCourses.Date.Model;
using Microsoft.EntityFrameworkCore;

namespace LanguageCourses.Date.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CourseUser> CourseUsers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TokenModel> TokenModels { get; set; }
    }
}
