using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositoires;

namespace MvcCv.Controllers
{
    public class PortfolyoController : Controller
    {
        // GET: Deneyim
        PortfolyoRepository repo = new PortfolyoRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult PortfolyoEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult PortfolyoEkle(TabloPortfolyo p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult PortfolyoSil(int id)
        {
            TabloPortfolyo t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult PortfolyoGetir(int id)
        {
            TabloPortfolyo t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult PortfolyoGetir(TabloPortfolyo p)
        {
            TabloPortfolyo t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Resim = p.Resim;
            t.Resim2 = p.Resim2;
            t.Resim3 = p.Resim3;
            t.Resim4 = p.Resim4;
            t.Resim5 = p.Resim5;
            t.Resim6 = p.Resim6;
            t.Resim7 = p.Resim7;
            t.Resim8 = p.Resim8;
            t.Resim9 = p.Resim9;
            t.Resim10 = p.Resim10;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}