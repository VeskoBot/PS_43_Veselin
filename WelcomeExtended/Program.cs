using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Others;

namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                ///Ex 2
               /* User user = new User("121221112", "Ivan Ivanov", "iivanov@tu-mail.bg", "Parola!23", UserRolesEnum.STUDENT);
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);

                view.Display();

                //Throw Error
                view.DisplayError();*/

                //Ex 3
                UserData userData = new UserData();

                User studentUserFirst = new User
                {
                    Names = "student1",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };
                User studentUserSecond = new User
                {
                    Names = "student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };
                User teacherUser = new User
                {
                    Names = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR
                };
                User adminUser = new User
                {
                    Names = "admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN
                };
                userData.AddUser(studentUserFirst);
                userData.AddUser(studentUserSecond);
                userData.AddUser(teacherUser);
                userData.AddUser(adminUser);
                Console.WriteLine("Enter a username:");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter a password:");
                string? pass = Console.ReadLine();
                User user = UserHelper.GetUser(userData, name, pass);
                string message = user.ToString();
                Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Delegates.Log);
                log += Delegates.Log2;
                log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
            Console.ReadKey();
        }
    }
}