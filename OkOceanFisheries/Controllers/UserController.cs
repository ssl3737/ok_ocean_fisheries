using OkOceanFisheries.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkOceanFisheries.Controllers
{
    public class UserController : Controller
    {
        private OOFContext db = new OOFContext();
        // GET: User
        [Authorize(Roles = "Admin, User")]
        public new ActionResult User()
        {
            return View();
        }
    }
}
