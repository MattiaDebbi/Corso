using Microsoft.AspNetCore.Mvc;

namespace Corso.Controllers
{
    public class CoursesControllers : Controller
    {
        public IActionResult Indice()
        {
            return Content("Sono Indice");
        }

        public IActionResult Dettagli(string id)
        {
            return Content ($"Sono Dettagli, ho ricevuto l'id:{id}");
        }
    }
}