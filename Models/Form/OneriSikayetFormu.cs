using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace TrafficKurye.Models.Form
{
    public class OneriSikayetFormu
    {
        [MaxLength(25)]
        [Display(Name = "Ad Soyad")]
        public string AdıSoyad { get; set; }

        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public int TelNo { get; set; }

        [Display(Name = "Email Adresi")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                          ErrorMessage = "Email adresi geçersiz")]
        public string EmailAdresi { get; set; }


        [Display(Name = "Gönderi Barkod Numarası")]
        public int? GonderiBarkodNo { get; set; }

        [Display(Name = "Başvuru Nedeni")]
        [Required(ErrorMessage = "Başvuru Nedeniniz")]
        public bool BasvuruNedeni { get; set; }
        
        //public List<BasvuruNedenModel> MevcutNedenListesi { get; set; }

        [Display(Name = "Mesaj")]
        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string Mesaj { get; set; }

        
    }
}