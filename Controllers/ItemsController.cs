using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Equipment.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Random()
        {
            return View();
        }
    }
}