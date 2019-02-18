using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Abc.MvcWebUI.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Boş olamaz..")]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş olamaz..")]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Boş olamaz..")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş olamaz..")]
        [DisplayName("E-Posta")]
        [EmailAddress(ErrorMessage = "Geçersiz Eposta.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş olamaz..")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş olamaz..")]
        [DisplayName("Tekrar Şifre")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor..")]
        public string RePassword { get; set; }
    }
}