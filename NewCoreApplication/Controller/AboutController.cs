using Microsoft.AspNetCore.Mvc;

namespace NewCoreApplication.Controller
{
    public class AboutController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AboutController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //TODO: Un Comment this code in real time for demo
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
