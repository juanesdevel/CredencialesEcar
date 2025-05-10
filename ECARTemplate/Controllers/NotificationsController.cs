using Microsoft.AspNetCore.Mvc;

namespace ECARTemplate.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Sweetalert2() => View();
        public IActionResult Toastr() => View();
    }
}
