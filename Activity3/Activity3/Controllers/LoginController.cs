using Activity3.Models;
using Activity3.Services.Business;
using System;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(UserModel model)
        {

            //Validate form POST
            if (!ModelState.IsValid)
                return View("Login");
            try
            {

                SecurityService service = new SecurityService();
                bool result = service.Authenticate(model);
                if (result)
                {
                    return View("LoginPassed", model);

                }
                else return View("LoginFailed");

            }
            catch (Exception e)
            {
                return View("LoginFailed");
            }

        }

    }
    
}