using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM Users");
            return View(dt);
        }
        public async Task<IActionResult> tables()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM Users");
            return View(dt);
        }
        public async Task<IActionResult> charts()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM Users");
            return View(dt);
        }
        public async Task<IActionResult> staticnav()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM Users");
            return View("layouts/staticnav", dt);
        }
        public async Task<IActionResult> lightnav()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM Users");
            return View("layouts/lightnav", dt);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
