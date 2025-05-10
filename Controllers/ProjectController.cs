using Microsoft.AspNetCore.Mvc;

namespace Arrual.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult City()
        {
            return View();
        }
        public IActionResult WorkingProjects()
        {
            return View();
        }
        public IActionResult CreateProject()
        {
            return View();
        }
    }
}
