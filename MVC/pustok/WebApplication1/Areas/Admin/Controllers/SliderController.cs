using WebApplication1.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using PustokDbContext db = new PustokDbContext();
            return View(await db.Sliders.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
