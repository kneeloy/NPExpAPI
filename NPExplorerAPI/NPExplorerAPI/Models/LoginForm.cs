using System;
namespace NPExplorerAPI.Models
{
    public class LoginForm
    {
        String userName;
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        String password;
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
