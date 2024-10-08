using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifreyi giriniz.")]
        public string Password { get; set; }
    }
}
