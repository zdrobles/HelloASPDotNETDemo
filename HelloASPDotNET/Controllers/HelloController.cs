using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("/helloworld")]
        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        // GET: /<controller>/welcome?name=value
        [HttpGet]
        [Route("")]
        [Route("/helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content(string.Format("<h1>Welcome to my app, {0}!</h1>", name), "text/html");
        }
    }
}
