using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    FacultyNumber="12123",
                    Names = "user",
                    Password = "password",
                    Email = "Hane@gmail.com",
                    Expiry = DateTime.Now,
                    Role = UserRolesEnum.STUDENT
                });
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.WriteLine("Enter a name:");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter a password:");
                string? pass = Console.ReadLine();
                Console.ReadKey();
                var user = users.FirstOrDefault(u => u.Names.Equals(name) && u.Password.Equals(pass));
                if(user is not null)
                    Console.WriteLine("Valid User");
                else
                    Console.WriteLine("Invalid User");
            }
        }
    }
}