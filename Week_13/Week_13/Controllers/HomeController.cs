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
        public IActionResult InsertUser(UserViewModel userViewModel)
        {
            var result = _context.ValidationTime(userViewModel);

            if (result != null)
            {
                return Json(result);
            }

            _context.AddUser(userViewModel);


            return Json("Your visit is booked!");
        }

        [HttpGet]
        public IActionResult GetUsers()
        {   
            var result = _context.GetUsers();
            return View(result);
        }

        [Route("BookingNotAllowed")]
        public IActionResult BookingNotAllowed()
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
