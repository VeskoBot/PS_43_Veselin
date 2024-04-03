using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }
        public int Id
        {
            get { return _user.Id; }
            set { _user.Id = value; }
        }
        public string FacultyNumber
        {
            get { return _user.FacultyNumber;}
            set { _user.FacultyNumber = value;}
        }
        public string Name
        {
            get { return _user.Names; }
            set { _user.Names = value; }
        }
        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }
        public string Password 
        { 
           get { return _user.Password; }
           set { _user.Password = value; }
        }
        public UserRolesEnum Role 
        {
            get {return _user.Role; }
            set { _user.Role = value; }
        }
        public DateTime Expiry
        {
            get { return _user.Expiry; }
            set { _user.Expiry = value; }
        }
    }
}
