using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripProject.Models.Sınıflar;

namespace TripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: Default1
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}