using Activity4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Mark", "mark@mail", "8562079"));
            users.Add(new UserModel("Mark2", "mark2@mail", "8562080"));
            users.Add(new UserModel("Mark3", "mark3@mail", "8562081"));

            return View("Test", users);
        }
    }
}