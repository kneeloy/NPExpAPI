using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using NPExplorerAPI.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NPExplorerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthenticationController : Controller
    {
        // POST: api/<controller>
        [HttpPost("GR")]
        public AuthenticationStatusReply AuthenticateUser(LoginForm formData)
        {
            Console.WriteLine("In authentication");
            AuthenticationStatusReply authreply = new AuthenticationStatusReply();
            // Validate the user name and password with jsonDB
            bool AuthStatus = true;
            if (formData.UserName == "kneeloy")
            {
                authreply.AuthenticationKey = "12345";
                authreply.UserName = "Niloy"; //ToDo get it from JsonDB
            }
            else
            {
                authreply.AuthenticationKey = null;
                authreply.UserName = null;
            }

            return authreply;
        }
    }
}

