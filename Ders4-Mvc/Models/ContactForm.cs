using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ders4_Mvc.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage ="İsim Boş Geçilemez")]
        [DisplayName("Adınız Soyadınız: ")]
        [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage ="Sadece Yazı Girebilirsiniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Boş Geçilemez")]
        [EmailAddress(ErrorMessage = "Email Formatı Yanlış")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mesaj Boş Geçilemez")]
        public string Message { get; set; }

    }
}
