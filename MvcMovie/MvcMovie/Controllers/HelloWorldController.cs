using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b> default </b> action";
        }

        public string details(string name, int id)
        {
            return HttpUtility.HtmlEncode("HEllo"+ name+" , id:"+id);
        }
    }
}