using grcasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace grcasp.Controllers
{
    public class VentesController : Controller
    {
        // GET: Ventes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Devis()
        {
            CreerDevisTest();

            return View();
        }

        public ActionResult NouveauDevis()
        {
            return View();
        }
    }
}