using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;
        public IActionResult page401()
        {
            return View();
        }
        public IActionResult page404()
        {
            return View();
        }
        public IActionResult page500()
        {
            return View();
        }
        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
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
