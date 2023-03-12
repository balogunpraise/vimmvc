using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace vimmvc.Controllers.Dashboards
{
    public class AdminDashboardController : Controller
    {
		public IActionResult Index()
		{

			return View();
		}
	}
}
