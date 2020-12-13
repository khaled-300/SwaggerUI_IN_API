using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Swagger.UI.TecUnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger.UI.TecUnica.API.Controllers
{
    //[Route("[controller]")]
    public class SwaggerUIController : Controller
    {
        private readonly IConfiguration _configuration;

        public SwaggerUIController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        //[Route("[action]")]
        public ActionResult Index()
        {
            var model = _configuration.GetSection(nameof(EndpointsConfiguration)).Get<EndpointsConfiguration>();
            return View(model);
        }


    }
}
