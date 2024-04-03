using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("Welcome\nUser: {0}\nRole: {1}",_viewModel.Name,_viewModel.Role);
        }
        public void DisplayMain()
        {
            Console.WriteLine("Welcome\nUser: {0}\nPassword: {1}", _viewModel.Email, _viewModel.Password);
        }
        public void DisplayError()
        {
            throw new Exception("Test Error");
        }
    }
}
