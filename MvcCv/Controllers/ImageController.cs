﻿using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Web;

using System.Web.Mvc;

using MvcCv.Models.Entity;
using MvcCv.Repositoires;

namespace Mvc.Controllers

{

    public class HakkimdaController : Controller

    {

        // GET: Hakkimda

        DbCvEntities db = new DbCvEntities();
        GenericRepository<TabloHakkimda> repo = new GenericRepository<TabloHakkimda>();
        [HttpGet]

        public ActionResult Index()

        {

            var hobiler = repo.List();

            return View(hobiler);
        }
        [HttpPost]

        public ActionResult Index(TabloHakkimda p)

        {

            if (Request.Files.Count > 0)

            {

                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);

                string uzanti = Path.GetExtension(Request.Files[0].FileName);

                string yol = "~/image/" + dosyaadi + uzanti;

                Request.Files[0].SaveAs(Server.MapPath(yol));

                p.Resim = "/image/" + dosyaadi + uzanti;



            }



            var t = repo.Find(x => x.ID == 1);

            t.Ad = p.Ad;

            t.Soyad = p.Soyad;

            t.Telefon = p.Telefon;

            t.Mail = p.Mail;

            t.Resim = p.Resim;

            t.Aciklama = p.Aciklama;

            repo.TUpdate(t);

            return RedirectToAction("Index");

        }

    }

}