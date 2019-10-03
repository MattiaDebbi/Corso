
using Microsoft.AspNetCore.Mvc;

namespace Corso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return Content("Sono la index della home");
        }
    }
}