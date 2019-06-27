using System;
namespace NPExplorerAPI.Models
{
    public class AuthenticationStatusReply
    {
        String authenticationKey;

        public String AuthenticationKey
        {
            get { return authenticationKey; }
            set { authenticationKey = value; }
        }

        String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}