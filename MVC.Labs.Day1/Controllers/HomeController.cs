using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Labs.Day1.Controllers
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var result = new ViewResult();
            return result;
        }
        [HttpGet]
        public ViewResult RegestrationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegestrationForm(User user)
        {
            if(user.name!=null&&user.email!=null&&user.password!=null)
            {
                ViewBag.Name = user.name;
                return View("Welcome");
            }
            return View();
        }

    }
}