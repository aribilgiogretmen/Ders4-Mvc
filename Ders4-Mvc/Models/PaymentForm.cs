using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ders4_Mvc.Models
{
    public class PaymentForm
    {
        [Required(ErrorMessage ="Kart Sahibi Adı Boş Geçilemez")]
        [DisplayName("Kart Sahibi Adı Girin")]
        public string CardHolderName { get; set; }

        [Required(ErrorMessage = "Kart Numarası Boş Geçilemez")]
        [CreditCard(ErrorMessage ="Hatalı Kart Numarası")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Hatalı Son Kullanma Tarihi")]
        [RegularExpression(@"\d{2}/\d{2}",ErrorMessage ="Hatalı Tarih")]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "Hatalı Son Kullanma Tarihi")]
        [RegularExpression(@"\d{3}$",ErrorMessage ="Hatalı CVV Kodu")]
        public string CVV { get; set; }
    }
}
