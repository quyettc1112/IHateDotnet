using Microsoft.AspNetCore.Mvc;

namespace IHateDotnet.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
