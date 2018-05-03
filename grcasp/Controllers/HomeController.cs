﻿using grcasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace grcasp.Controllers
{
    public class HomeController : Controller
    {
        Dal dal = new Dal();

        public ActionResult Index()
        {
            dal.CreerDevisTest("1972");
            return View();
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