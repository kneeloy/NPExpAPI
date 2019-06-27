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
    public class AttributesController : Controller
    {
        // GET: api/values
        [HttpGet("IR")]
        public AttributesResponseModel GetAllIrelandAttributes()
        {
            return CountryDetailAttributesCollection.getInstance().getAllAttributes("IR");
        }

        [HttpGet("GR")]
        public AttributesResponseModel GetAllGermanAttributes()
        {
            return CountryDetailAttributesCollection.getInstance().getAllAttributes("GR");
        }
    }
}