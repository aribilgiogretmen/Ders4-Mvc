using Ders4_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders4_Mvc.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PaymentForm model)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "Ödeme Yaptığınız için Teşekkür Ederim";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
