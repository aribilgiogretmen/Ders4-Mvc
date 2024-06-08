using Ders4_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders4_Mvc.Controllers
{
    public class OrderController : Controller
    {
        private List<Book>GetBooks()
        {
            return new List<Book>
            { 
                new Book {Id=1, Title="C# Öğreniyorum",Author="İbrahim ALPAK"},
                new Book {Id=2, Title="PHP Öğreniyorum",Author="Ali Veli"}

            };
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id=1, Name="Buse Gönek",Email="buse@buse.com"},
                new Customer {Id=2, Name="Melih AK",Email="melih@melih.com"}
            };
        }


        public IActionResult Index()
        {
            var model = new OrderViewModel
            {
                Books = GetBooks(),
                Customers=GetCustomers() 
            };
            
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(OrderViewModel model)
        {
            if(ModelState.IsValid)
            {

                //Bu alanda DB ye insert edeceğim.

                TempData["SuccessMessage"] = "Siparişiniz Başarılı";
                return RedirectToAction("Index");

            }
            model.Books=GetBooks();
            model.Customers=GetCustomers();
            return View(model);
        }


    }
}
