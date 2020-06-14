using KitapKurdu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitapKurdu.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageBooks))
                return View("Index");

            else
                return View("NonAdminUser");

        }
    }
}