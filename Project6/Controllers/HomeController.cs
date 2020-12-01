using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //string content = System.IO.File.ReadAllText(Server.MapPath(~/App_Data/PageContext.txt));
            
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(float princ, float rate, float dur)
        {
            Response.StatusCode = 200;
            Response.StatusDescription = "ok";

            String content = "The principle of $" + princ +
                " with an interest rate of " + rate +
                "% for " + dur + " has a monthly payment of _.";

            return new ContentResult()
            {
                Content = content,
                ContentEncoding = System.Text.Encoding.ASCII,
                ContentType = "text/html"
            };
        }
    }
}