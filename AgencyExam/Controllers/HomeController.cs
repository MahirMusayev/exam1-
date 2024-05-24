
using AgencyExam.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AgencyExam.Controllers
{
    public class HomeController(AgencyContext _context) : Controller
    {

        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolios.ToListAsync());
        }

    }
}
