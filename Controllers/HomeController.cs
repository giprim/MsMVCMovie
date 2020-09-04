using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MsMVC.Data;
using MsMVC.Models;

namespace MsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly MsMVCContext _context;
        public HomeController(MsMVCContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            
            return View(await _context.Movie.ToListAsync());
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
