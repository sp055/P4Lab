using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD5
{
    public class User
    {
        public static List<User> UserList = new List<User>();
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public static void AddUserToList(User user)
        {
            UserList.Add(user);
        }
    }
}
