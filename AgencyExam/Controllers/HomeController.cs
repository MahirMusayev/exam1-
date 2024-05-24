
using Microsoft.AspNetCore.Mvc;


namespace AgencyExam.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
