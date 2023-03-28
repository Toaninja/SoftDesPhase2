using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    using System;

    namespace SoftDesPhase2Engine.Classes
    {
        public class User
        {
            public string Username { get; private set; }
            private string password;
            public string Email { get; private set; }

            public User(string username, string password, string email)
            {
                Username = username;
                this.password = password;
                Email = email;
            }

            public bool Login(string enteredPassword)
            {
                return enteredPassword == password;
            }

            public void UpdatePassword(string newPassword)
            {
                password = newPassword;
            }

            public bool ValidateEmail()
            {
                // Logic to validate email address format
                return true;
            }
        }
    }
}
