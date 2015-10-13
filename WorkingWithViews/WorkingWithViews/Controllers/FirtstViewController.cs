using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingWithViews.Controllers
{
    public class FirtstViewController : Controller
    {
        // GET: FirtstView
        public ActionResult Index()
        {
            return View();
        }
    }
}