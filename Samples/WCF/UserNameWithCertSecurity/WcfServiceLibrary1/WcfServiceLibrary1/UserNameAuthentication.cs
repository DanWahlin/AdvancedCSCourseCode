using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace WcfServiceLibrary
{
    class UserNameAuthentication : UserNamePasswordValidator
    {
            public override void Validate(string userName, string password)
            {
                // validate arguments
                if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException("Supply username");
                if (string.IsNullOrEmpty(password)) throw new ArgumentNullException("Supply password");

                // Normally hit the Database to do lookup but hard-coded here for simplicity
                if (userName != "dan" || password != "password")
                {
                    throw new SecurityTokenException("Username or password not valid");
                }
            }
    }
}
