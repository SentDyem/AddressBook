using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View("~/Views/Some/Index.cshtml");
        }
    }
}