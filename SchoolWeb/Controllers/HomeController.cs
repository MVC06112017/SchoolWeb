using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolWeb.Models;

namespace SchoolWeb.Controllers
{
    public class HomeController : Controller
    {
        private SchoolDB context = new SchoolDB();

        // GET: Home
        public ActionResult Index()
        {


            return View("Index", context.Students.ToList());
        }
    }
}