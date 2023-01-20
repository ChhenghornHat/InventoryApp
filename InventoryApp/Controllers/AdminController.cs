using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult ManageUser()
        {
            return View();
        }
    }
}
