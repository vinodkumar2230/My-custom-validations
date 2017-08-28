using Customvalidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customvalidations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Employee model)
        {  

            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Email = model.Email;
                ViewBag.Password = model.Password;
                ViewBag.City = model.City;
            }
            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}