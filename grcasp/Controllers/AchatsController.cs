﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace grcasp.Controllers
{
    public class AchatsController : Controller
    {
        // GET: Achats
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Factures()
        {
            return View();
        }
    }
}