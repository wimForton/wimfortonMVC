using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace wimfortonMVC.Controllers
{
    public class ResumeController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            ViewData["NumTextblokken"] = 5;
            ViewData["Titel"] = "Titel inhoud";
            ViewData["Textblok"] = "Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud Textblok inhoud";
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
