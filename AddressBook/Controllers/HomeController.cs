using AddressBook.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Session["name"] = "Tom";
            ViewData["Head"] = "Привет мир!";
            HttpContext.Response.Cookies["id"].Value = "cb-2392rt";
            ViewData["Info"] = "Нажми на кнопку!";
            ViewBag.Head = "Привет! Нажми на кнопку снизу";
            ViewBag.Code = new List<string>
            {
                "C#","Visual Basic","Pascal"
            };
            return View();
        }
        public string GetData()
        {
            string id = HttpContext.Request.Cookies["id"].Value;
            var val = Session["name"];
            return val.ToString();
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
        public string GetId(int id)
        {
            return id.ToString();

        }
        public string Square()
        {
            int a = Int32.Parse(Request.Params["a"]);
            int h = Int32.Parse(Request.Params["h"]);
            double s = a * h / 2;
            return ($"<h2> Площадь треугольника с основанием  {a} и высотой {h} равна {s} </h2>");
        }
        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public string PostBook()
        {
            string address = Request.Form["address"];
            string number = Request.Form["number"];
            return address + " " + number;
        }
        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Testing elements in ASP.NET</h2>");
        }
        public ActionResult GetImage()
            {
            string path = "../Content/Images/example.jpg";
            return new ImageResult(path);
            }

        public ActionResult GetVoid(int id)
        {
            if (id > 3)
            {
                //return RedirectToAction("Square", "Home", new { a = 10, h = 4 });
                return new HttpStatusCodeResult(500);
            }

            return View("About");
        }
        public FilePathResult GetFile()
        {
            string file_path = Server.MapPath("~/Files/installer.exe");
            string file_type = "application/exe";
            string file_name = "installer.exe";
            return File(file_path, file_type, file_name);
        }

        public FileContentResult GetBytes()
        {
            string file = Server.MapPath("~/Files/installer.exe");
            byte[] mas = System.IO.File.ReadAllBytes(file);
            string file_type = "application/exe";
            string file_name = "installer.exe";
            return File(mas, file_type, file_name);
        }
        public string GetContext()
        {
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Используемый браузер - </p>" + browser +"<p>User-Agent - </p>"+ user_agent +"<p>URL - </p>"+ url +"<p>Ip адрес - </p>"+ ip +"<p>Реферер - </p>" + referrer;
        }



    }
}