using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public virtual int Id { get; set; }
        private string _password;
        public string FacultyNumber { get; set; }
        public string Names { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password
        {
            get
            {
                string pass = "";
                if(_password is not null)
                    foreach (char symbol in _password)
                    {
                        pass += (char)(symbol + 1);
                    }
                return pass;
            }
            set
            {
                string pass = "";
                if (value is not null)
                    foreach (char symbol in value)
                    {
                        pass += (char)(symbol - 1);
                    }
                _password = pass;
            }
        }
        public UserRolesEnum Role { get; set; }
        public DateTime Expiry { get; set; }

        public User(string facultyNumber, string names, string email, string password, UserRolesEnum role)
        {
            Id = new Random().Next();
            FacultyNumber = facultyNumber;
            Names = names;
            Email = email;
            Password = password;
            Role = role;
            Expiry = DateTime.Now.AddYears(1);
        }

        public User()
        {
        }
    }
}
