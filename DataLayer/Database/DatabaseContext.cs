using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            //Create a users
            var users = new List<DatabaseUser>
            {
                new DatabaseUser()
                {
                    FacultyNumber="12123",
                    Id = 1,
                    Names = "John Doe",
                    Password = "12345",
                    Email = "Hane@gmail.com",
                    Role = UserRolesEnum.ADMIN,
                    Expiry = DateTime.Now.AddYears(1)
                },
                new DatabaseUser()
                {
                    FacultyNumber="12123",
                    Id = 2,
                    Names = "Peter Doe",
                    Password = "12345",
                    Email = "Hane@gmail.com",
                    Role = UserRolesEnum.STUDENT,
                    Expiry = DateTime.Now.AddYears(1)
                },
                new DatabaseUser()
                {
                    FacultyNumber="12123",
                    Id = 3,
                    Names = "Smith Doe",
                    Password = "12345",
                    Email = "Hane@gmail.com",
                    Role = UserRolesEnum.PROFESSOR,
                    Expiry = DateTime.Now.AddYears(1)
                },
                new DatabaseUser()
                {
                    FacultyNumber="12123",
                    Id = 4,
                    Names = "Name",
                    Password = "12345",
                    Email = "Hane@gmail.com",
                    Role = UserRolesEnum.STUDENT,
                    Expiry = DateTime.Now.AddYears(1)
                },
            };
            modelBuilder.Entity<DatabaseUser>()
                .HasData(users);
        }
    }
}
