using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    public class UserService
    {
        public bool ValidateUser(string username, string password)
        {
            return username == "123" && password == "123";
        }
    }
}
