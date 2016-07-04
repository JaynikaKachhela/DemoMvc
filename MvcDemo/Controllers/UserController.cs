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
        public string Index()
        {
            return "Index page...";
        }
        public string Welcome()
        {
            return "welcome to JP...";
        }
        public string Count(int count,string name)
        {
            return HttpUtility.HtmlEncode("The number given is "+count+". Name of User : "+name);
        }
    }
}