using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wimfortonMVC.Models;

namespace wimfortonMVC.Controllers
{
    public class ThreejsController : Controller
    {
        public IActionResult Index()
        {
            double mx = 1;
            Cube cube = new Cube
            {
                x = mx,
                y = mx,
                z = mx
            };

            ViewBag.Message = cube;
            string initstring = "initial data";
            ViewData.Add("MyData", initstring);
            return View();
        }

        //public IActionResult GetData(string myData)
        //{
        //    ViewData["MyData"] = "This is Ziggy Rafiq Blog Site";
        //    return View("Index");
        //}

        public IActionResult xIncr(double x, double y, double z)
        {
            double add = 0.1;
            Cube cube = new Cube
            {
                x = x + add,
                y = y,
                z = z
            };

            ViewBag.Message = cube;
            return View("Index");
        }

        public IActionResult xDecr(double x, double y, double z)
        {
            Cube cube = new Cube
            {
                x = x - 0.2,
                y = y,
                z = z
            };

            ViewBag.Message = cube;
            return View("Index");
        }

        public IActionResult yIncr(double x, double y, double z)
        {
            Cube cube = new Cube
            {
                x = x,
                y = y + 0.2,
                z = z
            };

            ViewBag.Message = cube;
            return View("Index");
        }

        public IActionResult yDecr(double x, double y, double z)
        {
            Cube cube = new Cube
            {
                x = x,
                y = y - 0.2,
                z = z
            };

            ViewBag.Message = cube;
            return View("Index");
        }

        public IActionResult zIncr(double x, double y, double z)
        {
            Cube cube = new Cube
            {
                x = x,
                y = y,
                z = z + 0.2
            };

            ViewBag.Message = cube;
            return View("Index");
        }

        public IActionResult zDecr(double x, double y, double z)
        {
            Cube cube = new Cube
            {
                x = x,
                y = y,
                z = z - 0.2
            };

            ViewBag.Message = cube;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
