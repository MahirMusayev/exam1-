using AgencyExam.DAL;
using AgencyExam.Models;
using AgencyExam.ViemModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgencyExam.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController(AgencyContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolios.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePortfoliaVM vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _context.Portfolios.AddAsync(new Portfolio
            {
                Name = vm.Name,
                Subtitle = vm.Subtitle,
                ImageUrl = vm.ImageUrl,
            });
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1) return BadRequest(ModelState);
            var exsited = await _context.Portfolios.FirstOrDefaultAsync(x => x.Id == id);
            if (exsited == null) return NotFound();
            return View(exsited);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, CreatePortfoliaVM vm)
        {
            if (id == null || id < 1) return BadRequest(ModelState);
            var exsited = await _context.Portfolios.FirstOrDefaultAsync(x => x.Id == id);
            if (exsited == null) return NotFound();
            exsited.Name = vm.Name;
            exsited.Subtitle = vm.Subtitle;
            exsited.ImageUrl = vm.ImageUrl;
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int? id, CreatePortfoliaVM vm)
        {
            if (id == null || id < 1) return BadRequest(ModelState);
            var exsited = await _context.Portfolios.FirstOrDefaultAsync(x => x.Id == id);
            if (exsited == null) return NotFound();
            _context.Remove(exsited);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
