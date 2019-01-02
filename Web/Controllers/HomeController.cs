using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HubController hub=new HubController();
            hub.Post("First");

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
