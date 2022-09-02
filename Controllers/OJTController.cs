using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace OJT_Management.Controllers
{
    public class OJTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
