using Microsoft.AspNetCore.Mvc;
using pwiii.Models;

namespace pwiii.Controllers
{
    public class loginController : Controller
    {
        [HttpGet]
        public IActionResult Logar(loginmodel dados)
        {
            loginmodel model = new loginmodel();
            return View(model);
        }
    }
}
