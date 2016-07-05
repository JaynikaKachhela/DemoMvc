using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "welcome to JP...";
        }
        public ActionResult Count(int count,string name)
        {
            ViewBag.message="Name of User : "+name;
            ViewBag.count = count;
            return View();
        }
    }
}

