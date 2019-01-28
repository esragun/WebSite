using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrafficKurye.Models
{
    public class FooterMail
    {
        [MaxLength(25), MinLength(5)]
        [Required(ErrorMessage = "Lütfen Boş Bırakmayınız..")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email adresi geçersiz")]
        [DataType(DataType.EmailAddress)]
        public string EmailFooter { get; set; }
    }
}