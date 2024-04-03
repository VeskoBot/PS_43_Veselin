using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Names = "Ivan Ivanov";
            user.Password = "Parola!23";
            user.Role = UserRolesEnum.INSPECTOR;
            UserViewModel userViewModel = new UserViewModel(user);
            UserView userView = new UserView(userViewModel);
            userView.Display();
            userView.DisplayMain();
            Console.ReadKey();
        }
    }
}