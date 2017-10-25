using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_Tutorial.Controllers
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
            var stay_logged = Request["stayLogged"];

            if (email == "test@test.com" && password == "test")
            {
                //Checkboxes are submitted with "on"-value, in case they are checked
                if (stay_logged == "on")
                {
                    var auth_cookie = new HttpCookie("misleading_name");
                    auth_cookie.Value = "Some_Nonce_Value";
                    auth_cookie.Expires = DateTime.Now.AddDays(14d);
                    auth_cookie.Path = "localhost:2077";

                    Response.Cookies.Add(auth_cookie);
                    // use a "custom" cookie with a duration of today + 2 weeks
                }
                else
                {
                    // return a "default" ASP.NET Session-Id-Cookie
                    Session["misleading_name"] = "Some_Nonce_Value"; //creates session immediately
                }

                Response.Redirect("Index");
                // stay_logged_in
            }
            else
            {
                ViewBag.content = "Failed to login";
            }

            return View();
        }
    }
}