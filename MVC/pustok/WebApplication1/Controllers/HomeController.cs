using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        
        
        public async Task<IActionResult> Index()
        {
            using PustokDbContext context = new PustokDbContext();
            var sliders = await context.Sliders.ToListAsync();
            return View(sliders);
        }

        
    }
}
