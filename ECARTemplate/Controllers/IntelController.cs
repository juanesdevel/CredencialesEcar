using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECARTemplate.Controllers
{
    [Authorize(Roles = "Grupo SGI TI Desarrollo")]

    public class IntelController : Controller
    {
        public IActionResult AnalyticsDashboard() => View();

        public IActionResult Introduction() => View();

        public IActionResult MarketingDashboard() => View();

        public IActionResult Privacy() => View();
    }
}
