using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digioz.Calendar.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? year, int? month)
        {
            if (year != null && month != null)
            {
                ViewBag.Year = year;
                ViewBag.Month = month;
            }

            return View();
        }
    }
}