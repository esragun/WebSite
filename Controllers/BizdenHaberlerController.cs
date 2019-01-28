using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrafficKurye.Models;

namespace TrafficKurye.Controllers
{
    public class BizdenHaberlerController : Controller
    {
        // GET: BizdenHaberler
        public ActionResult BizdenHaber()
        {
            List<ResimModel> _bizdenHaberResList = Extension.BizdenHaberResimListOlustur();
            return View(_bizdenHaberResList);
        }

        public ActionResult SosyalSorumluluk()
        {
            List<ResimModel> _sosyalSorumlulukResList = Extension.SosyalSorumlulukResimListOlustur();
            return View(_sosyalSorumlulukResList);
        }

        public ActionResult SevgililerGunuDagıtım()
        {
            List<ResimModel> _sevigililerGunuResList = Extension.SevgililerGunuResimListOlustur();
            return View(_sevigililerGunuResList);
        }

        public ActionResult PostaHizmetCalistayi()
        {
            List<ResimModel> _postaHizmetCalistayResList = Extension.PostaHizmetCalistayiResimListOlustur();
            return View(_postaHizmetCalistayResList);
        }

        public ActionResult PostaHizmetYetkiBelgesi()
        {
            List<ResimModel> _postaHizmetYetkiBelResList = Extension.PostaHizmetYetkiResimListOlustur();
            return View(_postaHizmetYetkiBelResList);
        }

        public ActionResult BolgeselAcenteToplatı()
        {
            List<ResimModel> _acenteResList = Extension.AcenteResimListOlustur();
            return View(_acenteResList);
        }

        public ActionResult BowlingTurnuvası()
        {
            List<ResimModel> _bowlingResList = Extension.BowlingResimListOlustur();
            return View(_bowlingResList);
        }

        public ActionResult EgitimToplantısı()
        {
            List<ResimModel> _egitimTopResList = Extension.EgitimTopResimListOlustur();
            return View(_egitimTopResList);
        }
    }
}