using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToString(this User user)
        {
            return user.Names + " with email " + user.Email;
        }
        public static bool ValidateCredentials(this UserData users,string name,string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }
            return users.ValidateUser(name, password);
        }
        public static User GetUser(this UserData users, string name, string password)
        {
            if (ValidateCredentials(users, name, password))
                return users.GetUser(name, password);
            else throw new Exception("User does not exist");
        }
    }
}
