using grcasp.Models;
using grcasp.ViewModels.Ventes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace grcasp.Controllers
{
    public class VentesController : Controller
    {
        Dal dal = new Dal();
        
        // GET: Ventes
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Devis()
        {
            DevisViewModel vm = new DevisViewModel
            {
                ListeDesDevis = dal.ObtientTousLesDevis()
            };
            return View(vm);
        }

        public ActionResult NouveauDevis()
        {
            return View();
        }
    }
}