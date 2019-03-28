using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity7.Controllers
{
    public class PlayController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Play");
        }

        [HttpPost]
        public ActionResult MyInts(ICollection<int> ints)
        {
            return View("Play");
        }

        [HttpPost]
        public ActionResult MyButton(string mine)
        {
            return View("Play");
        }
    }
}