
using Microsoft.EntityFrameworkCore;

namespace MiniEdDb.Models {
    
    public class AppDbContext : DbContext {

        public virtual DbSet<Major> Majors { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;

        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;"
                          + "database=MiniEdDb;"
                          + "trustServerCertificate=true;"
                          + "trusted_connection=true;";
            builder.UseSqlServer(connStr);  
        }
    }
}
