using Microsoft.AspNetCore.Mvc;

namespace FINALASPNET.Controllers
{
    public class FinController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
