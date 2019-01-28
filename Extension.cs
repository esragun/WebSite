using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using TrafficKurye.Models;

namespace TrafficKurye
{
    public static class Extension
    {


        public static List<BelgeModel> ListayeLisansveYetkiBelgesiEkle()
        {
            BelgeModel belge1 = new BelgeModel() { ImgUrl = "btk-yetki-belge.jpg", BelgeBaslik = "BTK Yetki Belgesi", Icerik = "BTK, Bilgi Teknoloji Kurumu'ndan Evrensel Posta Hizmet Sağlayıcısı Belgesi" };
            BelgeModel belge2 = new BelgeModel() { ImgUrl = "yetki_belgesi_buyuk.jpg", BelgeBaslik = "Ulaştırma Bakanlığı Belgesi", Icerik = "R1 Ulaştırma Bakanlığı'ndan Taşıma ve Dağıtım Belgesi" };
            BelgeModel belge3 = new BelgeModel() { ImgUrl = "p1nb.jpg", BelgeBaslik = "Ulaştırma Bakanlığı Belgesi", Icerik = "P1 Ulaştırma Bakanlığı'ndan Taşıma ve Dağıtım Belgeleri" };
            BelgeModel belge4 = new BelgeModel() { ImgUrl = "iso90012.jpg", BelgeBaslik = "ISO 9001 Belgesi", Icerik = "ISO 9001,Uluslar Arası Kalite Yönetim Sistemi Standardı Belgesi" };
            BelgeModel belge5 = new BelgeModel() { ImgUrl = "iso27001.png", BelgeBaslik = "ISO 27001 Sertifikası", Icerik = "ISO 27001 Bilgi Güvenliği Sertifikası" };
            BelgeModel belge6 = new BelgeModel() { ImgUrl = "iso22301.png", BelgeBaslik = "ISO 22301 Sertifikası", Icerik = "ISO 22301 Bilgi Güvenliği Sertifikası" };
            BelgeModel belge7 = new BelgeModel() { ImgUrl = "iso03034.png", BelgeBaslik = "Bilgi Güvenliği & İş Sürekliliği Politikamız", Icerik = "Bilgi güvenliği ve iş sürekliliği için gerekli tedbirler alınmaktadır." };


            List<BelgeModel> _belgeList = new List<BelgeModel>();

            _belgeList.Add(belge1);
            _belgeList.Add(belge2);
            _belgeList.Add(belge3);
            _belgeList.Add(belge4);
            _belgeList.Add(belge5);
            _belgeList.Add(belge6);
            _belgeList.Add(belge7);

            return _belgeList;
        }

        public static List<Haber> listeyeHaberEkle()
        {
            Haber haber1 = new Haber() { ImgUrl = "anadolu_saglik_201706.JPG", HaberBaslik = "Bizden Haberler", Icerik = "Haziran 2017 itibariyle Anadolu Sigorta sağlık poliçesi ile...", ActionLinkAdi = "BizdenHaber", ControllerAdi = "BizdenHaberler" };
            Haber haber2 = new Haber() { ImgUrl = "2017-23-3_1 (2).jpg", HaberBaslik = "Sosyal Sorumluluk", Icerik = "Traffic Kurye ailesi olarak, doğudaki çocuklarımı..", ActionLinkAdi = "SosyalSorumluluk", ControllerAdi = "BizdenHaberler" };
            Haber haber3 = new Haber() { ImgUrl = "2017-14-2.JPG", HaberBaslik = "Sevgililer Günü Özel Dağıtım", Icerik = "14 Şubatta yaklaşık 1000 sevgiliye..", ActionLinkAdi = "SevgililerGunuDagıtım", ControllerAdi = "BizdenHaberler" };
            Haber haber4 = new Haber() { ImgUrl = "2017-2-4.JPG", HaberBaslik = "2017 Posta Hizmetleri Çalıştayı", Icerik = "Şirketimiz; Ulaştırma, Denizcilik ve..", ActionLinkAdi = "PostaHizmetCalistayi", ControllerAdi = "BizdenHaberler" };
            Haber haber5 = new Haber() { ImgUrl = "btk-yetki-belge.jpg", HaberBaslik = "Posta Hizmetleri Yetki Belgesi", Icerik = "2014 Eylül ayında başvuru yapmış olduğumuz Bilgi..", ActionLinkAdi = "PostaHizmetYetkiBelgesi", ControllerAdi = "BizdenHaberler" };
            Haber haber6 = new Haber() { ImgUrl = "2014-2-6.JPG", HaberBaslik = "Bölgesel Acente Toplantısı", Icerik = "2014 yılında 6 bölgede “Bölgesel Acente Toplantısı", ActionLinkAdi = "BolgeselAcenteToplatı", ControllerAdi = "BizdenHaberler" };
            Haber haber7 = new Haber() { ImgUrl = "2012-1-3.jpg", HaberBaslik = "Bowling Turnuvası", Icerik = "2012 Yaz Ayında Cevahir Alışveriş Merkezinde, Şirket Bowling..", ActionLinkAdi = "BowlingTurnuvası", ControllerAdi = "BizdenHaberler" };
            Haber haber8 = new Haber() { ImgUrl = "2012-1-3.jpg", HaberBaslik = "Eğitim Toplantısı", Icerik = "2012 yılı Nisan ayında, Kuşadası Fantasia Hotel’de, Türkiye’deki tüm..", ActionLinkAdi = "EgitimToplantısı", ControllerAdi = "BizdenHaberler" };

            List<Haber> _haberList = new List<Haber>();

            _haberList.Add(haber1);
            _haberList.Add(haber2);
            _haberList.Add(haber3);
            _haberList.Add(haber4);
            _haberList.Add(haber5);
            _haberList.Add(haber6);
            _haberList.Add(haber7);
            _haberList.Add(haber8);

            return _haberList;
        }

        public static List<ResimModel> BizdenHaberResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "anadolu_saglik_201706.JPG"};

            List<ResimModel> _bizdenHaberResimList = new List<ResimModel>();

            _bizdenHaberResimList.Add(ImgUrl1);
            
            return _bizdenHaberResimList;
        }

        public static List<ResimModel> AcenteResimListOlustur()
        { 
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2014-2-1.JPG" };
            ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2014-2-2.JPG" };
            ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2014-2-3.JPG" };
            ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2014-2-4.JPG" };
            ResimModel ImgUrl5 = new ResimModel() { ImgUrl = "2014-2-5.JPG" };
            ResimModel ImgUrl6 = new ResimModel() { ImgUrl = "2014-2-6.JPG" };

            List<ResimModel> _acenteResimList = new List<ResimModel>();

            _acenteResimList.Add(ImgUrl1);
            _acenteResimList.Add(ImgUrl2);
            _acenteResimList.Add(ImgUrl3);
            _acenteResimList.Add(ImgUrl4);
            _acenteResimList.Add(ImgUrl5);
            _acenteResimList.Add(ImgUrl6);

            return _acenteResimList;
        }

        public static List<ResimModel> BowlingResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2012-1-1.JPG" };
            ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2012-1-2.JPG" };
            ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2012-1-3.JPG" };
            ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2012-1-4.JPG" };

            List<ResimModel> _bowlingResimList = new List<ResimModel>();

            _bowlingResimList.Add(ImgUrl1);
            _bowlingResimList.Add(ImgUrl2);
            _bowlingResimList.Add(ImgUrl3);
            _bowlingResimList.Add(ImgUrl4);

            return _bowlingResimList;
        }

        public static List<ResimModel> EgitimTopResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2012-2-1.JPG" };
            ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2012-2-2.JPG" };
            ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2012-2-3.JPG" };
            ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2012-2-4.JPG" };
            ResimModel ImgUrl5 = new ResimModel() { ImgUrl = "2012-2-5.JPG" };
            ResimModel ImgUrl6 = new ResimModel() { ImgUrl = "2012-2-6.JPG" };

            List<ResimModel> _egitimTopResimList = new List<ResimModel>();

            _egitimTopResimList.Add(ImgUrl1);
            _egitimTopResimList.Add(ImgUrl2);
            _egitimTopResimList.Add(ImgUrl3);
            _egitimTopResimList.Add(ImgUrl4);
            _egitimTopResimList.Add(ImgUrl5);
            _egitimTopResimList.Add(ImgUrl6);

            return _egitimTopResimList;
        }

        public static List<ResimModel> PostaHizmetCalistayiResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2017-2-2.JPG" };
            ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2017-2-3.JPG" };
            ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2017-2-4.JPG" };
            ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2017-2-5.JPG" };

            List<ResimModel> _postaHizmetCalistayResimList = new List<ResimModel>();

            _postaHizmetCalistayResimList.Add(ImgUrl1);
            _postaHizmetCalistayResimList.Add(ImgUrl2);
            _postaHizmetCalistayResimList.Add(ImgUrl3);
            _postaHizmetCalistayResimList.Add(ImgUrl4);

            return _postaHizmetCalistayResimList;
        }

        public static List<ResimModel> PostaHizmetYetkiResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "btk-yetki-belge.jpg" };

            List<ResimModel> _postaHizmetYetkiCalistayResimList = new List<ResimModel>();

            _postaHizmetYetkiCalistayResimList.Add(ImgUrl1);

            return _postaHizmetYetkiCalistayResimList;
        }

        public static List<ResimModel> SevgililerGunuResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2017-14-1.JPG" };
            ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2017-14-2.JPG" };
            ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2017-14-3.JPG" };
            ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2017-14-4.JPG" };
            ResimModel ImgUrl5 = new ResimModel() { ImgUrl = "2017-14-5.JPG" };
            ResimModel ImgUrl6 = new ResimModel() { ImgUrl = "2017-14-6.JPG" };

            List<ResimModel> _sevgililerGunuResimList = new List<ResimModel>();

            _sevgililerGunuResimList.Add(ImgUrl1);
            _sevgililerGunuResimList.Add(ImgUrl2);
            _sevgililerGunuResimList.Add(ImgUrl3);
            _sevgililerGunuResimList.Add(ImgUrl4);
            _sevgililerGunuResimList.Add(ImgUrl5);
            _sevgililerGunuResimList.Add(ImgUrl6);

            return _sevgililerGunuResimList;
        }

        public static List<ResimModel> SosyalSorumlulukResimListOlustur()
        {
            ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2017-23-3_1.JPG" };
            ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2017-23-3_2.JPG" };
            ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2017-23-3_3.JPG" };
            ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2017-23-3_4.JPG" };
            ResimModel ImgUrl5 = new ResimModel() { ImgUrl = "2017-23-3_5.JPG" };
            ResimModel ImgUrl6 = new ResimModel() { ImgUrl = "2017-23-3_6.JPG" };

            List<ResimModel> _sosyalSorumlulukResimList = new List<ResimModel>();

            _sosyalSorumlulukResimList.Add(ImgUrl1);
            _sosyalSorumlulukResimList.Add(ImgUrl2);
            _sosyalSorumlulukResimList.Add(ImgUrl3);
            _sosyalSorumlulukResimList.Add(ImgUrl4);
            _sosyalSorumlulukResimList.Add(ImgUrl5);
            _sosyalSorumlulukResimList.Add(ImgUrl6);

            return _sosyalSorumlulukResimList;
        }



        //public static List<ResimModel> Deneme()
        //{

        //    ResimModel ImgUrl1 = new ResimModel() { ImgUrl = "2012-1-1.JPG" , CurrentDiv=1 };
        //    ResimModel ImgUrl2 = new ResimModel() { ImgUrl = "2012-1-2.JPG" , CurrentDiv=2};
        //    ResimModel ImgUrl3 = new ResimModel() { ImgUrl = "2012-1-3.JPG" , CurrentDiv=3};
        //    ResimModel ImgUrl4 = new ResimModel() { ImgUrl = "2012-1-4.JPG" , CurrentDiv=4};

        //    List<ResimModel> _bowlingResimList = new List<ResimModel>();

        //    _bowlingResimList.Add(ImgUrl1);
        //    _bowlingResimList.Add(ImgUrl2);
        //    _bowlingResimList.Add(ImgUrl3);
        //    _bowlingResimList.Add(ImgUrl4);

        //    return _bowlingResimList;
        //}


    }
}