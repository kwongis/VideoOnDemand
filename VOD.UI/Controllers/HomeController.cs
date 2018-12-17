using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VOD.Data.Data.Entities;
using VOD.UI.Models;

namespace VOD.UI.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<User> _signInManager;
        public HomeController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Dashboard", "Membership");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
