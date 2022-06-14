using JuanProject.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanProject.Areas.Manage.Controllers
{
[Area("Manage")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Sliders.ToList();
            return View(data);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
