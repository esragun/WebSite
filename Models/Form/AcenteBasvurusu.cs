using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace TrafficKurye.Models.Form
{
    public class AcenteBasvurusu
    {
        [Required(ErrorMessage =("Lütfen bu alanı doldurunuz"))]
        [MaxLength(25), MinLength(2)]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }

        [Required(ErrorMessage = ("Lütfen bu alanı doldurunuz"))]
        [MaxLength(25), MinLength(2)]
        [Display(Name = "Doğum Yeri")]
        public string DogumYeri { get; set; }

        [Range(00000000000, 99999999999)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [DisplayFormat(DataFormatString = "{0:11111111111}")]
        [Display(Name = "Tc Kimlik Numarası")]
        public int TcKimlikNo { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Eğitim Durumu")]
        public bool EgitimDurumu { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [StringLength(100)]
        [Display(Name = "Firma Adı")]
        public string FirmaAdi { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [StringLength(100)]
        [Display(Name = "Firma Adresi")]
        [DataType(DataType.MultilineText)]
        public string FirmaAdres { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "İs Telefon Numarası")]
        public int IsTelNo { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Cep Telefon Numarası")]
        public int CepTelNo { get; set; }

        [MaxLength(25), MinLength(5)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                          ErrorMessage = "Email adresi geçersiz")]
        [EmailAddress]
        [Display(Name = "Email Adresi")]
        public string EmailAdresi { get; set; }

        [Display(Name = "Web Sitesi")]
        [DataType(DataType.MultilineText)]
        public string WebSitesi { get; set; }

        [Display(Name = "Faks Numarası")]
        public int? FaksNo { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [Display(Name = "Vergi Dairesi Adı")]
        public string VergiDairesi { get; set; }

        [Display(Name = "Vergi Dairesi Numarası")]
        [Range(0000000000, 9999999999)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [DisplayFormat(DataFormatString = "{0:1111111111}")]
        public int VergiNo { get; set; }

        [Display(Name = "Acente Il Adı")]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        public string AcenteIl { get; set; }

        [Display(Name = "Acente İlçe Adı")]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        public string AcenteIlce { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [Display(Name = "Sektör Tecrübesi(yıl)")]
        public int SektorTecrubesi { get; set; }

        [Display(Name = "Açıklama")]
        [MaxLength(1000), MinLength(2)]
        [DataType(DataType.MultilineText)]
        public string Aciklama { get; set; }

        [Display(Name = "Kurye Sayısı")]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        public int KuryeSayisi { get; set; }

        [Display(Name = "Araç Sayısı")]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        public int AracSayisi { get; set; }

        [Display(Name = "Motor Sayısı")]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        public int MotorSayisi { get; set; }

        [Display(Name = "Ofis Alanı(m2)")]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [MaxLength(50),MinLength(1)]
        public string Ofism2 { get; set; }

        [StringLength(50)]
        [Display(Name = "Referansınızın Adı Soyadı")]
        public string ReferansAdiSoyadi { get; set; }

        [Display(Name = "Referansınızın Çalıştığı Yer")]
        [StringLength(50)]
        public string ReferansCalistigiYer { get; set; }

        [Display(Name = "Referansınızın Çalıştığı Pozisyon")]
        [StringLength(50)]
        public string ReferansCalistigiPozisyon { get; set; }

        [Display(Name = "Referansınızın Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public int? ReferansTelNo { get; set; }
        
        [Display(Name = "Sahip Olunan Yetki Belgesi")]
        [DataType(DataType.MultilineText)]
        public string SahipOlunanYetkiBelgesi { get; set; }
        
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [StringLength(1000)]
        [Display(Name = "Bizi Tercih Nedeniniz")]
        [DataType(DataType.MultilineText)]
        public string BiziTercihNedeni { get; set; }

        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [StringLength(1000)]
        [Display(Name = "Acentenizin Beklentisi")]
        [DataType(DataType.MultilineText)]
        public string AcentelikBeklentisi { get; set; }

        [Required]
        [Display(Name = "Taahhüt")]
        public bool Taahhüt { get; set; }
        

    }
}