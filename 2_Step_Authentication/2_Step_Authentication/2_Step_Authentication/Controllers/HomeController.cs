using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nexmo.Api;
using System.Net;

namespace _2_Step_Authentication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            var username = Request["email"];
            var password = Request["password"];

            if (username == "test" && password == "test")
            {
                var secret = "121212";

                var mode = "SMS_EMAIL";

                if (mode == "SMS_EMAIL")
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://rest.nexmo.com/sms/json");

                    var postData = "api_key=e...";
                    postData += "";
                }



                var result = SMS.Send(new SMS.SMSRequest
                {
                    from = "Nexmo Ver.",
                    to = "+41793939162",
                    text = secret
                });

            }

            RedirectToAction("Index", "Home");
            return View();
        }
    }
}