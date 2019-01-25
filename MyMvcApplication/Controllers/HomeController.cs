using MyMvcApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyRepository myRepository = new MyRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            int v = this.myRepository.GetValue();

            return View(v);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}