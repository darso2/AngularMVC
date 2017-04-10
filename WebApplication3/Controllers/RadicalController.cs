using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class RadicalController : Controller
    {
        // GET: Radical
        public ActionResult extra()
        {
            ViewData["hope"] = "AMAZING";
            return View("Castle");
        }
    }
}