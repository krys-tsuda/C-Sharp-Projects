using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerTime.Models;
using System.Diagnostics;



namespace ServerTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITimeService _timeService;

        public HomeController(ILogger<HomeController> logger, ITimeService timeService)
        {
            _logger = logger;
            _timeService = timeService;   // initialize service
        }

        public IActionResult Index()
        {
            var model = new ServerTimeViewModel
            {
                ServerTime = _timeService.GetCurrentTime()
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
