using Ders4_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders4_Mvc.Controllers
{
    public class ContactWController : Controller
    {

        private List<ContactTopic>GetContactTopics()
        {
            return new List<ContactTopic> { 
                
                new ContactTopic{Id=1,Name="Genel"},
                new ContactTopic{Id=2,Name="Özel"},
                new ContactTopic{Id=3,Name="Seni İlgilendirmez"}
           };

        }

        public IActionResult Index()
        {
            var model = new ContactFormViewModel
            {
                ContactTopics = GetContactTopics()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ContactFormViewModel model)
        {
           if (ModelState.IsValid)
            {

                TempData["Message"] = "işlem Başarılı";
                return RedirectToAction("Index");

            }

            model.ContactTopics = GetContactTopics();
            return View(model);
        }


    }
}
