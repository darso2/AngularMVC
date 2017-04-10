using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult rack()
        {
            
            return View("Words","","World");
            
        }
    }
}