using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace LTWeb15CTH12Advanced.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext()
            : base("LTWeb15CTH12Connection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}