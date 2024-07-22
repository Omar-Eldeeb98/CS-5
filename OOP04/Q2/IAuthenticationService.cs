using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Q2
{
    public interface IAuthenticationService
    {

        public bool AuthenticateUser(string name, string password);

        public bool AuthorizeUser(string name, string role);
         


    }
}
