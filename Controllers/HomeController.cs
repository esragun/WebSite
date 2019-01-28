using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using TrafficKurye.Models;
using TrafficKurye.Models.Form;

namespace TrafficKurye.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkımızda()
        {
            return View();
        }

        public ActionResult LisansVeYetkiBelgelerimiz()
        {
            List<BelgeModel> _belgeList = Extension.ListayeLisansveYetkiBelgesiEkle();
            return View(_belgeList);
        }

        public ActionResult Hizmetlerimiz()
        {
            return View();
        }
        
        public ActionResult BizdenHaberler()
        {

            List<Haber> haberler = Extension.listeyeHaberEkle();
            return View(haberler);
        }

        public ActionResult EkHizmetler()
        {
            return View();
        }
        
        public ActionResult GonderiSorgulama()
        {
            return View();

        }

        public ActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Iletisim(FormCollection model)
        {
            if (FormExtension.MailGonder(model,"Iletisim Form"))
            {

                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Gönderim Başarılı!";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {

                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Gönderim Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }
            return View();
        }

        public ActionResult Kariyer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kariyer(FormCollection model)
        {
            if (FormExtension.MailGonder(model, "Kariyer Form"))
            {

                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Gönderim Başarılı!";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {

                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Gönderim Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }
            return View();
        }

        public ActionResult AcentelikBasvurusu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AcentelikBasvurusu(FormCollection model)
        {
            if (FormExtension.MailGonder(model, "Acentelik Basvurusu Form"))
            {

                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Gönderim Başarılı!";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {

                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Gönderim Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }
            return View();
        }
        
        public ActionResult OneriVeSikayetFormu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OneriVeSikayetFormu(FormCollection model)

        {
            if (FormExtension.MailGonder(model, "Öneri ve Şikayet Form"))
            {

                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Gönderim Başarılı!";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {

                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Gönderim Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }
            return View();
        }

        public ActionResult PartialPageGonderiSorgula()
        {
           return PartialView("_PartialPageGonderiSorgula");
        }

        [HttpPost]
        public ActionResult FooterEmailGonder(FormCollection model)
        {

            if (FormExtension.MailGonder(model, "Bizden Haberdar Olmak İsteyen Kişi Mail"))
            {

                ViewBag.Sonuc = "info";
                ViewBag.Mesaj = "Gönderim Başarılı!";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {

                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Gönderim Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Footer ()
        {
            return PartialView("_PartialPageFooter");
        }

        
        //public ActionResult Deneme()
        //{
        //    List<ResimModel> _bowlingResList = Extension.BowlingResimListOlustur();
        //    return View(_bowlingResList);
        //}



    }
}