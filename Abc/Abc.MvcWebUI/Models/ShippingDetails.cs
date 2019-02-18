using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen adres tanımını giriniz.")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen bir adres giriniz.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen bir sehir giriniz.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen ilçenizi belirtiniz.")]
        public string Ilce { get; set; }
        [Required(ErrorMessage = "Lütfen mahallenizi belirtiniz.")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Posta Kodu boş olamaz.")]
        public string PostaKodu { get; set; }
    }
}