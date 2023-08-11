using LoginRegister.DTOs;
using LoginRegister.Models;
using LoginRegister.SqlData;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace LoginRegister.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {

            List<UserDto> user = _context.Users.Select(x => new UserDto()
            {
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                Password = x.Password
            }).ToList();

            return View(user);
        }
        [HttpPost]
        public IActionResult Register(UserDto dto)
        {
            User users = new()
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Password = dto.Password
            };

            _context.Users.Add(users);
            _context.SaveChanges();


            return View();
        }
    }
}
