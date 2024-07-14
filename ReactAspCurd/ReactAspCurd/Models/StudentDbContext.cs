
using Microsoft.EntityFrameworkCore;
namespace ReactAspCurd.Models
{
    public class StudentDbContext : DbContext
    {
        //public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        //{
        //}
        //public DbSet<Student> Student { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-32660EF\\SQLEXPRESS; Initial Catalog=ReactAPICurd;");
        //}

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    }
}
