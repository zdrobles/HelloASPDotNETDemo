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
        public IActionResult Index()
        {
            string html = "<form method='post' action='hello/display'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // POST: /<controller>/display
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        [HttpGet]
        public IActionResult Welcome(string name = "World")
        {
            return Content(string.Format("<h1>Welcome to my app, {0}!</h1>", name), "text/html");
        }

        [HttpGet]
        [Route("/hello/{name}")]
        public IActionResult WelcomeByName(string name)
        {
            return Content(string.Format("<h1>Welcome to my app, {0}!</h1>", name), "text/html");
        }

    }
}
