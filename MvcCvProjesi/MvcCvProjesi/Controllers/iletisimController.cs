using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProjesi.Models.entity;
using MvcCvProjesi.Repositories;
namespace MvcCvProjesi.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepositories<Tbliletisim> repo = new GenericRepositories<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}