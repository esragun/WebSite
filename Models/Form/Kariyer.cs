using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace TrafficKurye.Models.Form
{
    public class Kariyer
    {
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [MaxLength(25), MinLength(2)]
        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [MaxLength(25), MinLength(2)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [MaxLength(25), MinLength(5)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +@".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email adresi geçersiz")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Adresiniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }

        [MaxLength(25), MinLength(2)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [Display(Name = "Doğum Yeri")]
        public string DogumYeri { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Cinsiyet")]
        public bool Cinsiyet { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Uyruğunuz")]
        public bool Uyruk { get; set; }

        [Required(ErrorMessage ="Lütfen Boş Bırakmayınız..")]
        [MaxLength(25), MinLength(3)]
        [Display(Name = "Medeni Haliniz")]
        public string MedeniHal { get; set; }


        [StringLength(100)]
        [Display(Name = "Çocuk sayınızı ve yaşlarını giriniz")]
        public string SahipOlduguCocukSayisiVeYaslari { get; set; }

        [Display(Name = "Eşiniz çalışıyor mu")]
        public bool? EsininCalismaDurumu { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ehliyetiniz varsa sınıfını giriniz..")]
        [Display(Name = "Ehliyet var ise sınıfı")]
        public string Ehliyet { get; set; }

        [StringLength(50)]
        [Display(Name = "Askerlik Durumunuz")]
        public string AskerlikDurumu { get; set; }

        [Display(Name = "Sosyal Sigorta Numaranız")]
        public int? SosyalSigortaNo  { get; set; }

        [Display(Name = "Vergi Numaranız")]
        [DisplayFormat(DataFormatString = "{0:1111111111}")]
        public int? VergiNo { get; set; }
        
        [Range(00000000000,99999999999)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [DisplayFormat(DataFormatString = "{0:11111111111}")]
        [Display(Name = "Tc Kimlik Numaranız")]
        public int TcKimlikNo { get; set; }

        [Required(ErrorMessage ="Lütfen Boş Bırakmayınız..")]
        [StringLength(50)]
        [Display(Name = "Mesleğiniz")]
        public string Meslek { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [StringLength(50)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Adres Bilginiz")]
        public string Adres { get; set;}
    
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [Display(Name = "Telefon Numaranız")]
        public int TelNo { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Sabıka Kaydınız Var mı?")]
        public bool SabıkaKaydıVarMi { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Seyehat En geliniz Var Mı?")]
        public bool SeyehatEngeliVarMi { get; set; }

        [StringLength(50)]
        [Display(Name = "Okuduğunuz Lisenin Adı")]
        public string LiseOkulAdi { get; set; }

        [StringLength(50)]
        [Display(Name = "Lisedeki Bölümünüzün Adı")]
        public string LiseBolumAdi { get; set; }

        [MaxLength(10)]
        [Display(Name = "Lisedeki Eğitim Süreniz")]
        public int? LiseEgitimSuresi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Lise Mezuniyet Tarihiniz")]
        public DateTime? LiseMezuniyetTarihi { get; set; }

        [StringLength(50)]
        [Display(Name = "Lisans Okul Adınız")]
        public string LisansOkulAdi { get; set; }

        [StringLength(50)]
        [Display(Name = "Lisans Bölümünüzün Adı")]
        public string LisansBolumAdi { get; set; }

        [MaxLength(10)]
        [Display(Name = "Lisans Eğitim Süreniz")]
        public int? LisansEgitimSuresi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Lisans Mezuniyet Tarihiniz")]
        public DateTime? LisansMezuniyetTarihi { get; set; }

        [StringLength(50)]
        [Display(Name = "Yüksek Lisans Okul Adı")]
        public string YuksekLisansOkulAdi { get; set; }

        [StringLength(50)]
        [Display(Name = "Yüksek Lisans Bölüm Adı")]
        public string YuksekLisansBolumAdı { get; set; }

        [MaxLength(10)]
        [Display(Name = "Yüksek Lisans Eğitim Süreniz")]
        public int? YuksekLisansEgitimSuresi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Yüksek Lisans Mezuniyet Tarihi")]
        public DateTime? YuksekLisansMezuniyetTarihi { get; set; }

        [StringLength(50)]
        [Display(Name = "Okuduğunuz Ikinci Okul Adı")]
        public string OkudugunuzIkinciOkulAdi { get; set; }

        [StringLength(50)]
        [Display(Name = "Okuduğunuz Ikinci Okul Bölüm Adı")]
        public string OkudugunuzIkinciOkulBolum { get; set; }

        [MaxLength(10)]
        [Display(Name = "Okuduğunuz Ikinci Okul Eğitim Süreniz")]
        public int? OkudugunuzIkinciOkulSuresi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Okuduğunuz Ikinci Okul Mezuniyet Tarihiniz")]
        public DateTime? OkudugunuzIkinciOkulMezuniyet { get; set; }

        [StringLength(100)]
        [Display(Name = "En Son Çalıştığınız Kurum Adı")]
        public string EnSonCalistigiKurumAdı { get; set; }

        [StringLength(100)]
        [Display(Name = "Yaptığınız İş")]
        public string EnSonCalistigiKurumdaYaptigiIs { get; set; }

        [StringLength(50)]
        [Display(Name = "Çalıştığınız Süre")]
        public string EnSonKurumdakiCalismaSureniz { get; set; }

        [Display(Name = "Aldığınız Ücret(Net)")]
        public string EnSonCalistigiKurumdanAldıgıNetUcret { get; set; }

        [StringLength(500)]
        [Display(Name = "Ayrılma Nedeniniz")]
        [DataType(DataType.MultilineText)]
        public string EnSonkiİşindenAyrilmaNedeni { get; set; }

        [StringLength(100)]
        [Display(Name = "Kurum Adı")]
        public string BirOncekiEskiIs { get; set; }

        [StringLength(100)]
        [Display(Name = "Yaptığınız İş")]
        public string BirOncekiEskiYapilanIs { get; set; }

        [StringLength(50)]
        [Display(Name = "Çalışma Süresi")]
        public string BirOncekiEskiYapilanIsSuresi { get; set; }

        [Display(Name = "Aldığınız Ücret")]
        public string BirOncekiEskiKurumUcreti { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Ayrılma Nedeniniz")]
        public string BirOncekiEskiIsAyrilmaNedeni { get; set; }

        [StringLength(100)]
        [Display(Name = "Kurum Adı")]
        public string EskiIs1 { get; set; }

        [StringLength(100)]
        [Display(Name = "Yaptığınız İş")]
        public string EskiYapilanIs_1 { get; set; }

        [StringLength(50)]
        [Display(Name = "Çalışma Süresi")]
        public string EskiYapilanIsSuresi_1 { get; set; }

        [Display(Name = "Aldığınız Ücret")]
        public string EskiKurumUcreti_1 { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Ayrılma Nedeniniz")]
        public string EskiIsAyrilmaNedeni_1 { get; set; }

        [StringLength(100)]
        [Display(Name = "Kurum Adı")]
        public string EskiIs_2 { get; set; }

        [StringLength(100)]
        [Display(Name = "Yaptığınız İş")]
        public string EskiYapilanIs_2 { get; set; }

        [StringLength(50)]
        [Display(Name = "Çalışma Süresi")]
        public string EskiYapilanIsSuresi_2 { get; set; }

        [Display(Name = "Aldığınız Ücret")]
        public string EskiKurumUcreti_2 { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Ayrılma Nedeniniz")]
        public string EskiIsAyrilmaNedeni_2 { get; set; }

        [DefaultValue(true)]
        [Display(Name = "İş yerinizin soruşturulmasında sakınca var mı?")]
        public bool IsYeriSorusturmaOnayı { get; set; }

        [StringLength(50)]
        [Display(Name = "Referansın Adı ve Soyadı")]
        public string ReferansAdsoyad_1 { get; set; }

        [StringLength(50)]
        [Display(Name = "Referansın İş Yeri ve Görevi")]
        public string ReferansIsyeriVeGorevi_1 { get; set; }

        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Referansın Adresi")]
        public string ReferansAdresi_1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Referansınızın Telefon Numarası")]
        public int? ReferansTelNo_1 { get; set; }

        [StringLength(50)]
        [Display(Name = "Referansın Adı ve Soyadı")]
        public string ReferansAdsoyad_2 { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Referansın İş Yeri ve Görevi")]
        public string ReferansIsyeriVeGorevi_2 { get; set; }
        
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Referansın Adresi")]
        public string ReferansAdresi_2 { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Referansınızın Telefon Numarası")]
        public int? ReferansTelNo_2 { get; set; }

        [StringLength(50)]
        [Display(Name = "Referansın Adı ve Soyadı")]
        public string ReferansAdsoyad_3 { get; set; }

        [StringLength(50)]
        [Display(Name = "Referansın İş Yeri ve Görevi")]
        public string ReferansIsyeriVeGorevi_3 { get; set; }

        [StringLength(100)]
        [Display(Name = "Referansın Adresi")]
        [DataType(DataType.MultilineText)]
        public string ReferansAdresi_3 { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Referansınızın Telefon Numarası")]
        public int? ReferansTelNo_3 { get; set; }

        [StringLength(2000)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Yaptığınız Stajlar")]
        public string YapilanStajlar { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Sigara içiyor musunuz?")]
        public bool SigaraKullanıyorMu { get; set; }

        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Yabancı Diller")]
        public string YabanciDiller { get; set; }

        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Katıldığınız kurslar ve eğitimler")]
        public string Kurslar { get; set; }

        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Kullanmayı bildiğiniz iş makinaları")]
        public string KullandıgıIsmakinalari { get; set; }

        [StringLength(150)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Kullanmayı bildiğiniz ofis makinaları")]
        public string KullandıgıOfisMakinalari { get; set; }

        [StringLength(600)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Özel bilgi ve becerileriniz")]
        [Required]
        public string OzelBilgiVeBeceriler { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "İstediğiniz Görev")]
        public string IstedigiGorev { get; set; }

        [StringLength(150)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Yapabileceğiniz diğer işler")]
        public string YapilabilecekDigerGorevler { get; set; }

        [Required(ErrorMessage ="Lütfen istediğiniz ücreti giriniz.")]
        [Display(Name = "İstediğiniz Ücret (NET)")]
        public string IstenilenNetUcret { get; set; }
        
        [Required]
        [DefaultValue(true)]
        [Display(Name = "Beyan")]
        public bool Beyan { get; set; }



    }
}