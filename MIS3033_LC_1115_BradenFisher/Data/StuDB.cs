using a;
using Microsoft.EntityFrameworkCore;

namespace MIS3033_LC_1115_BradenFisher.Data
{
    public class StuDB : DbContext// Change DbCon to your own database connect class name
    {
        public DbSet<Student> Students { get; set; }// Define a table in the database. The table name here is: Students
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=fish00901115db;Port=5432;Username=fish0090;Password=jFo9OvfVJ5QFHHspd1Au");
        }
    }

}
