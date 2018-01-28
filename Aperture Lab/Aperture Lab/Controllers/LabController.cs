using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aperture_Lab.Models;

namespace Aperture_Lab.Controllers
{
    public class LabController : Controller
    {
        // GET: Lab
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {

            return View();
        }

        public ActionResult History()
        {
            return View();
        }

    }
}