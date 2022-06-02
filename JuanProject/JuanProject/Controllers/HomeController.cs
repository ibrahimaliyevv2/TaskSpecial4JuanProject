using JuanProject.DAL;
using JuanProject.Models;
using JuanProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JuanProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList()
            };


            return View(homeViewModel);
        }

    }
}
