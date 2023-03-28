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

//Single Responsibility Principle (SRP): The User class has a single responsibility, which is to encapsulate the properties and behaviors related to a user entity.
//It does not have any unnecessary dependencies or concerns outside of this responsibility.

//Open/Closed Principle (OCP): The User class is not specifically designed to be open or closed for extension, as it does not have any extension points or mechanisms in place.
//However, it could be argued that the class is relatively easy to extend or modify, as it has a clear and simple interface and is not tightly coupled with other classes or modules.

//Liskov Substitution Principle (LSP): The User class does not have any inheritors or derived classes in this code, so the LSP is not relevant in this case.

//Interface Segregation Principle (ISP): The User class does not implement any interfaces in this code, so the ISP is not relevant in this case.

//Dependency Inversion Principle (DIP): The User class does not have any dependencies in this code, so the DIP is not relevant in this case. However,
//if the User class had any dependencies, they should be abstracted through interfaces or abstractions to follow the DIP.