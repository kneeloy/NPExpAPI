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
    public class UserRegistrationController : Controller
    {
        // POST: api/<controller>
        [HttpPost("GR")]
        public RegistrationStatusReply RegisterUser_GR(UserRegistrationForm_GR formData)
        {
            Console.WriteLine("In user registration");
            RegistrationStatusReply statusReply = new RegistrationStatusReply();

            //Ideally there should be helper class and function to do the following operation
            // Save the user name and password with jsonDB
            if(formData.PreRegisterdCode == "123435")
            {
                statusReply.RegistrationStatus = "OK";
            } else
            {
                statusReply.RegistrationStatus = "NO";
            }
            return statusReply;
        }

        // POST: api/<controller>
        [HttpPost("IR")]
        public RegistrationStatusReply RegisterUser_IR(UserRegistrationForm_IR formData)
        {
            Console.WriteLine("In user registration");
            RegistrationStatusReply statusReply = new RegistrationStatusReply();

            //Ideally there should be helper class and function to do the following operation
            // Save the user name and password with jsonDB
            if (formData.UserName == "Niloy")
            {
                statusReply.RegistrationStatus = "OK";
            }
            else
            {
                statusReply.RegistrationStatus = "NO";
            }
            return statusReply;
        }
    }
}
