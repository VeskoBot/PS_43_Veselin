﻿using System.Data;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }
        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password == password)
                         .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Names == name && user.Password == password
                      select user.Id;
            return ret != null ? true : false;
        }
        public User? GetUser(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password == password)
                         .FirstOrDefault();
        }
        public void AssignUserRole(string name, UserRolesEnum role)
        {
            User user = _users.Where(x => x.Names == name).FirstOrDefault();
            if(user is not null)
            {
                user.Role = role;
            }
        }
        public void SetActive(string name, DateTime date)
        {
            User user = _users.Where(x => x.Names == name).FirstOrDefault();
            if (user is not null)
            {
                user.Expiry = date;
            }
        }
    }
}
