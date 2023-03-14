using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class Negocio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
