using Ders4_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders4_Mvc.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactForm model)
        {
            if(ModelState.IsValid)
            {

                TempData["Message"] = "Formu Doldurduğunuz için Teşekkür Ederim";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
