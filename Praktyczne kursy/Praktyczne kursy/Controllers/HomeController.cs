using Praktyczne_kursy.DAL;
using Praktyczne_kursy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praktyczne_kursy.Controllers
{
    public class HomeController : Controller
    {

        private KursyContext db = new KursyContext();

        public ActionResult Index()
        {
            Kategoria kategoria = new Kategoria { NazwaKategorii = "asp.net mvc", NazwaPlikuIkon = "aspNetMvc.png", OpisKategorii = "opis" };
            db.Kategorie.Add(kategoria);
            db.SaveChanges();

            return View();
        }
    }
}