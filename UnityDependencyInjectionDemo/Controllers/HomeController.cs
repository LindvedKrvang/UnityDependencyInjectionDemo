using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDependencyInjectionDemo.Services;
using UnityDependencyInjectionDemo.ViewModels;

namespace UnityDependencyInjectionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnnouncer _announcer;

        public HomeController(IAnnouncer announcer)
        {
            _announcer = announcer;
        }
        public ActionResult Index()
        {
            string announcement = _announcer.Announcement();

            ViewModel model = new ViewModel
            {
                Data = announcement
            };


            return View("Index", model);
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
    }
}