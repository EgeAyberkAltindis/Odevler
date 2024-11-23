using System.ComponentModel.DataAnnotations;

namespace ASpNetCoreMVC_BasicIdentity.Models.ViewModels
{
    public class RegisterVM
    {
        [Display(Name ="Kullanıcı Ad")]
        [Required(ErrorMessage ="kullanıcı ad boş geçilemez!")]
        public string Username { get; set; }

        [Display(Name = "Eposta")]
        [Required(ErrorMessage = "Eposta  boş geçilemez!")]
        [EmailAddress(ErrorMessage ="lütfen email formatında bir değer girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Şifre (Tekrar)")]
        [Required(ErrorMessage = "Şifre (Tekrar) boş geçilemez!")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil")]
        public string ConfirmPassword { get; set; }

    }
}
