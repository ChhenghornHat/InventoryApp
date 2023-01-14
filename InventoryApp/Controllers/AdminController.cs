using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult ViewLogin()
        {
            return View();
        }
        public IActionResult ViewDashboard()
        {
            return View();
        }

        public IActionResult ViewManageUser()
        {
            return View();
        }
    }
}
