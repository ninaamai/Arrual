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
        //public IActionResult Cities()
        //{
        //    return View();
        //}
        //public IActionResult Projects()
        //{
        //    return View();
        //}
        //public IActionResult AddProject()
        //{
        //    return View();
        //}
    }
}
