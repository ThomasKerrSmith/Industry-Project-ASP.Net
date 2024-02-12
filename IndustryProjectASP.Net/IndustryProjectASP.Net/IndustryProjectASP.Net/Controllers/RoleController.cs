using IndustryProjectASP.Net.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndustryProjectASP.Net.Controllers
{
    public class RoleController : Controller
    {
        [Authorize(Roles = "Administrator , Manager")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Manager()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
