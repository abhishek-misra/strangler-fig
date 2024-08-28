using Microsoft.AspNetCore.Mvc;
using NewCoreApplication.Models;

namespace NewCoreApplication.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var privacyList = new List<PrivacyViewModel>()
            {
                new PrivacyViewModel("First Section", "This First Section Privacy is fetched from Backend."),
                new PrivacyViewModel("Second Section", "This Second Section Privacy is fetched from Backend."),
                new PrivacyViewModel("Third Section", "This Third Section Privacy is fetched from Backend.")
            };

            return View(privacyList);
        }
    }
}