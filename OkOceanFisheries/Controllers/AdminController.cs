using OkOceanFisheries.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkOceanFisheries.Controllers
{
    public class AdminController : Controller
    {
        private OOFContext _context = new OOFContext();

        public ActionResult LockOut()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register page.";

            return View();
        }

        public ActionResult Edit()
        {         
            return View(_context.Employee.ToList());
        }
    }
}