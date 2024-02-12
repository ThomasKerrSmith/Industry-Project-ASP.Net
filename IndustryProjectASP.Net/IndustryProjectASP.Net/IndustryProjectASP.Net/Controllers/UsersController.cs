using IndustryProjectASP.Net.Areas.Identity.Data;
using IndustryProjectASP.Net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace IndustryProjectASP.Net.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _application;

        public UsersController(ApplicationDbContext application)
        {
            _application = application;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUsers()
        {
            var users = _application.Users.ToList();
            return View(users);
        }


    }
}
