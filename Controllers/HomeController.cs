using System;
using Prakash.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prakash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Empmodel emp = new Empmodel();
            //emp.id = 33;
            //emp.name = "prakash";
            //emp.email = "prakash@gmail.com";
            //emp.age = 27;
            ViewBag.name = "Prakash";
            ViewBag.age = 25;
            ViewBag.salary = 1500;
            ViewBag.country = new List<string>()
            {"IND","PAk","AUS"

            };
            
           TempData["name"] = "RAHUL";
           TempData["country"] = new List<string>()
            {"IND","RSA","uk"

            };

            return View();

        }

        public ActionResult About()
        {
            ViewData["name"] = "AMAN";
            ViewData["country"] = new List<string>()
            {"IND","PAk","AUS"

            };


            return View();
        }

        public ActionResult Contact()
        {
            Session["name"] = "AKASH";
            Session["country"] = new List<string>()
            {"ENG","UK","AUS"

            };

           

            return View();
        }
    }
}