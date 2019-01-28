using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrafficKurye.Controllers
{
    public class FooterController : Controller
    {
        // GET: Footer
        public ActionResult PostaGonderiveTarifelerimiz()
        {
            return View();
        }
        public ActionResult HizmetKalitesiveSorumluluk()
        {
            return View();
        }

        public ActionResult GonderiTurlerineGoreTeslimSureleri()
        {
            return View();
        }

        public ActionResult MusteriMemnuniyeti()
        {
            return View();
        }

        public ActionResult YasalUyari()
        {
            return View();
        }

        public ActionResult KisiselVerilerinKorunmasi()
        {
            return View();
        }

        public ActionResult Gizlilik()
        {
            return View();
        }

        public ActionResult SorumlulukveTazminat()
        {
            return View();
        }

    }
}