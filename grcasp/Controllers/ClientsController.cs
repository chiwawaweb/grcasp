using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using grcasp.Models;
using grcasp.ViewModels.Clients;

namespace grcasp.Controllers
{
    public class ClientsController : Controller
    {
        Dal dal = new Dal();
        
        // GET: Clients
        public ActionResult Index()
        {
            ClientsViewModel vm = new ClientsViewModel
            {
                ListeDesClients = dal.ObtientTousLesClients()
            };
            return View(vm);
        }

        public ActionResult NouveauClient()
        {
            return View();
        }

        public ActionResult Prospects()
        {
            return View();
        }
    }
}