using Microsoft.AspNetCore.Mvc;

namespace vimmvc.Controllers.Dashboards
{
    public class StaffDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
