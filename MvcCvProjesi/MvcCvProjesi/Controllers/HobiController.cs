using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProjesi.Models.entity;
using MvcCvProjesi.Repositories;
namespace MvcCvProjesi.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepositories<TblHobilerim> repo = new GenericRepositories<TblHobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobi = repo.List();
            return View(hobi);
        }
        [HttpPost]
        public ActionResult Index(TblHobilerim h)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama1 = h.Aciklama1;
            t.Aciklama2 = h.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}