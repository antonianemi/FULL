using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public class Credentials
    {

        public Credentials(string username,string password)
        {
            Username = username;
            Password = password;
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
