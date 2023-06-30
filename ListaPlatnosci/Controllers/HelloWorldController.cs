using ListaPlatnosci.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaPlatnosci.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<PaymentViewModel> payments = new List<PaymentViewModel>();
        public IActionResult Index()
        {

            return View(payments);
              
        }

        public IActionResult Create()
        {
            var paymentVm = new PaymentViewModel();
            return View(paymentVm);
        }

        public IActionResult CreatePayment(PaymentViewModel paymentViewModel)
        {
            payments.Add(paymentViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's tehre?";
        }
    }
}
