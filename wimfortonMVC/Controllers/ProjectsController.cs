using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace wimfortonMVC.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Midi()
        {
            return View();
        }
        public IActionResult Framework3D()
        {
            return View();
        }


    }
}
