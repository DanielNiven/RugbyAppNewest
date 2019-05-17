using RugbyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RugbyApp.Controllers
{
    public class HomeController : Controller
    {
        // Database connection
        AppDbContext db = new AppDbContext();

        // Home Page
        public ActionResult Index()
        {
            return View();
        }

        // Create Juniors
        public ActionResult CreateJuniors()
        {
            return View();
        }

        // Results
        public ActionResult Results()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Skills development
        public ActionResult SkillsDevelopment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //Training records
        public ActionResult TrainingRecords()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}