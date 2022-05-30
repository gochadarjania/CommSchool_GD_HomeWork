using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week_13.Models;
using Week_13.Services;

namespace Week_13.Controllers
{
    public class HomeController : Controller
    {
        private IBaseService _context;

        public HomeController(IBaseService context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void InsertUser(string firstName, string lastName, string doctor, string inputTime)
        {
            var time = TimeSpan.Parse(inputTime);

            UserViewModel userViewModel = new UserViewModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Doctor = doctor,
                Time = DateTime.Today.Add(time)
            };

            _context.AddUser(userViewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
