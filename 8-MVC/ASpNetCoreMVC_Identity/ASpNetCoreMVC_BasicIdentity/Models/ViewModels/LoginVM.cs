using System.ComponentModel.DataAnnotations;

namespace ASpNetCoreMVC_BasicIdentity.Models.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Eposta")]
        [Required(ErrorMessage = "Eposta  boş geçilemez!")]
        [EmailAddress(ErrorMessage = "lütfen email formatında bir değer girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
