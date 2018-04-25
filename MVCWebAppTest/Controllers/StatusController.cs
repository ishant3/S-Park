using MVCWebAppTest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebAppTest.Controllers
{
    public class StatusController : Controller
    {
        // GET: Status
        public ActionResult getStatus()
        {
            ServiceClient o = new ServiceClient();
            List<Parking_Space> li= o.GetStatus().ToList();
            ViewBag.List = li;
            return View();
        }
    }
}