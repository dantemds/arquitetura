using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaAplicada.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
