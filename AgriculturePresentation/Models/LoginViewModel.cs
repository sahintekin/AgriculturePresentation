using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Girin")]
        public string password { get; set; }
    }
}
