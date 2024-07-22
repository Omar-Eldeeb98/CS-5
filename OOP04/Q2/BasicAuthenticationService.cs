using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string name, string password)
        {
            if(name == "user" && password == "password")
            {
                return true;
            }
          

            return false;

        }

        public bool AuthorizeUser(string name, string role)
        {
            if (name == "admin" && role == "admin")
            { 
                return true; 
            }
            
                return false;
            
        }
    }
}
