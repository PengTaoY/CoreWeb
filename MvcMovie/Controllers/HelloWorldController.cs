using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<HelloWorld>/
        public IActionResult Index()
        {
            return View();
        }

        //public string Welcome(string name,int ID=1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name},NumTimes is:{ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"]= "Hello " + name;
            ViewData["Numtimes"] = numTimes;

            return View();
        }
    }
}
