using Microsoft.AspNetCore.Mvc;

namespace FINALASPNET.Controllers
{
    public class FinController : Controller
    {
        [Route("Index/{total}")]
        public IActionResult Index(double total)
        {
            ViewBag.total = total;
            return View();
        }
    }
}
