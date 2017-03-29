using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week11.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from viewbag";
            ViewBag.BallState = "BSU";
            ViewBag.counter = 5;
            return View();
        }
        public string SayHello(string fname, string lname) //url needs ?fname=John
        {
            return HttpUtility.HtmlEncode("Hello " + fname + " "+lname); //the encode is not needed for functionality but is a good idea for security
        }
    }
}