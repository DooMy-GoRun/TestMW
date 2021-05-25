using Microsoft.EntityFrameworkCore;

namespace TestMWCApp.Model.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestMWCappDB;Trust_Connection=True;");
        }
    }
}
