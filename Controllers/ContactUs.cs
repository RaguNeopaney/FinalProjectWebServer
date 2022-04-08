using Microsoft.AspNetCore.Mvc;

namespace FinalProjectWebServer.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult ContactUsHome()
        {
            return View();
        }
    }
}