using Microsoft.AspNetCore.Mvc;

namespace pwiii.Controllers
{
    public class SalasControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
