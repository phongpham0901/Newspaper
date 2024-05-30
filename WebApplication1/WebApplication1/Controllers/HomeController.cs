using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ActionFilter;

namespace WebApplication1.Controllers
{
    //[MyLogActionFilter]
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string MyController()
        {
            return "Hi, I am a Controller";
        }

        public ActionResult MyView()
        {
            return View();
        }

















        //// GET: Home
        //public ActionResult Index()
        //{
        //    return RedirectToAction("GetAllCustomers", "customer");
        //}

        //[OutputCache(Duration = 15)]
        //public string Index()
        //{
        //    return "Hello";
        //}

        ////[OutputCache(Duration = 20)]
        //[ActionName("CurrentTime")]
        //public string GetCurrentTime()
        //{
        //    return TimeString();
        //}

        //[NonAction]
        //public string TimeString() { return DateTime.Now.ToString("T"); }
    }
}