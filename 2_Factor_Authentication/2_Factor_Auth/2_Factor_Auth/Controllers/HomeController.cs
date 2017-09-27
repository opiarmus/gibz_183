using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Client ID: 993337614778-m1jvtg410a9ci2n9pvm7sfnhvk7tmatt.apps.googleusercontent.com
//Client Secret: BozeenEWPeXPohCojda16mSp

namespace _2_Factor_Auth.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name)
        {
            var email = Request["email"];
            var password = Request["password"];
            var code = Request["code"];



            return View();
        }
    }
}