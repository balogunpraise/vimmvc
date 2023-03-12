using Microsoft.AspNetCore.Mvc;
using vimmvc.Services;
using vimmvc.ViewModels.Auth;

namespace vimmvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthServices _authServices;

        public AccountController(AuthServices authServices)
        {
            _authServices = authServices;
        }

        [HttpGet]
        public IActionResult Index(string error)
        {
			if (error != null)
			{
				ViewBag.Error = error;
			}
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> Register([FromForm]BigAuthViewModel model)
        {
			if (ModelState.IsValid)
			{
				var response = await _authServices.RegisterUserAsync(model);
				string attachment = response.Item2 as string;
				if (response.Item1)
					return RedirectToAction("Index", attachment + "Dashboard");
			}
			return RedirectToAction("Index", new { error = "Somethine went wrong" });
		}

        [HttpPost]
        public async Task<IActionResult> Login([FromForm]BigAuthViewModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _authServices.AuhenticateUserAsync(model);
                string attachment = response.Item2 as string;
                if (response.Item1)
                    return RedirectToAction("Index", attachment + "Dashboard");
            }
            return RedirectToAction("Index", new {error = "Somethine went wrong"});
        }

        public async Task<IActionResult> Logout()
        {
            await _authServices.LogoutAsync();
            return RedirectToAction("Index");
        }
    }
}
