using FINALASPNET.Herramienta;
using FINALASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FINALASPNET.Controllers
{
    public class FinController : Controller
    {
        [Route("Index/{total}")]
        public IActionResult Index(double total)
        {
            List<Elemento> carrito = Conversor.RecuperarObjeto<List<Elemento>>(HttpContext.Session, "carrito");
            carrito.Clear();
            Conversor.GuardarObjeto(HttpContext.Session, "carrito", carrito);
            ViewBag.total = total;
            return View();
        }
    }
}
