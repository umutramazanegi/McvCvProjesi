using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProjesi.Models.entity;
using MvcCvProjesi.Repositories;
using System.Web.Security;
namespace MvcCvProjesi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        GenericRepositories<TblAdmin> repo = new GenericRepositories<TblAdmin>();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            DbCvEntities db = new DbCvEntities();
            var bilgi = db.TblAdmin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false);
                Session["KULLANICIADİ"] = bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Deneyim");

            }
            return RedirectToAction("Index", "Login");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}