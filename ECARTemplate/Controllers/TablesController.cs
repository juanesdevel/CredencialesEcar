using Microsoft.AspNetCore.Mvc;

namespace ECARTemplate.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Basic() => View();
        public IActionResult GenerateStyle() => View();
    }
}
