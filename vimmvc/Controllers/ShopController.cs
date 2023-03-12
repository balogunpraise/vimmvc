using Microsoft.AspNetCore.Mvc;

namespace vimmvc.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
