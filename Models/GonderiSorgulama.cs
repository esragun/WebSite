using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrafficKurye.Models
{
    public class GonderiSorgulama
    {
        [Display(Name = "Sipariş Numarası")]
        public string orderID { get; set; }

        [Display(Name = "(veya) Telefon Numarası")]
        public string AcceptorGsm { get; set; }

        [Display(Name = "İsminizin İlk İki Harfi")]
        public string AcceptorNameFL { get; set; }

    }
}