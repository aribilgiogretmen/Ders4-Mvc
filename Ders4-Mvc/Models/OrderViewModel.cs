using System.Collections;
using System.ComponentModel;

namespace Ders4_Mvc.Models
{
    public class OrderViewModel
    {
        //İd olarak post ettiğim alanlar
        [DisplayName("Müşteri Seçin: ")]
        public int CustomerId { get; set; }

        [DisplayName("Kitap Seçin: ")]
        public int BookId { get; set; }

        public string OrderNo { get; set; }

        //ilişkiler burda kuruluyor
        public IEnumerable<Book>Books { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
