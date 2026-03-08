using Microsoft.AspNetCore.Mvc;
using GameGaru.Models;

namespace GameGaru.Controllers
{
    public class RegistroController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Jugador jugador)
        {

            if (jugador.PagoMatricula == true)
            {
                ViewBag.Mensaje = "Ha completado su registro";
            }
            else
            {
                ViewBag.Mensaje = "Usted aún no ha completado su pago";
            }

            return View("Index");
        }
    }
}