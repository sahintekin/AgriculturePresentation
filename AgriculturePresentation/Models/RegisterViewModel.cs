﻿using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail  Giriniz")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("password",ErrorMessage ="Şifreler aynı değil")]
        public string passwordConfirm { get; set; }

     

        
    }
}
