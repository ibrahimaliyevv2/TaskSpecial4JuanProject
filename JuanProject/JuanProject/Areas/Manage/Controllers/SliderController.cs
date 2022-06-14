using JuanProject.DAL;
using JuanProject.Models;
using JuanProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace JuanProject.Controllers
=======
namespace JuanProject.Areas.Manage.Controllers
>>>>>>> 5d97ff2b11fd0b089879efa1394a3129d0c0e1f6
{
    [Area("Manage")]
    public class SliderController : Controller
    {
<<<<<<< HEAD
        private readonly AppDbContext _context;

=======
        

        private AppDbContext _context;
>>>>>>> 5d97ff2b11fd0b089879efa1394a3129d0c0e1f6
        public SliderController(AppDbContext context)
        {
            _context = context;
        }
<<<<<<< HEAD

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList()
            };

            return View(homeViewModel);
        }

=======
        
        public IActionResult Index()
        {

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList()
            };


            return View(homeViewModel);
        }

        ///////////////////////////////////////////////////////////////////////////////////


>>>>>>> 5d97ff2b11fd0b089879efa1394a3129d0c0e1f6
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Sliders.Add(slider);
            _context.SaveChanges();

<<<<<<< HEAD
            return RedirectToAction("Index");
        }


=======
            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
                return RedirectToAction("error", "dashboard");

            return View(slider);
        }

        [HttpPost]
        public IActionResult Edit(Slider slider)
        {
            if (!ModelState.IsValid)
                return View();

            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null)
                return RedirectToAction("error", "dashboard");

            existSlider.SubTitle = slider.SubTitle;
            existSlider.Title = slider.Title;

            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            Slider author = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (author == null)
                return RedirectToAction("error", "dashboard");

            return View(author);
        }

        [HttpPost]
        public IActionResult Delete(Slider slider)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);


            if (existSlider == null)
                return RedirectToAction("error", "dashboard");

            _context.Sliders.Remove(existSlider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
>>>>>>> 5d97ff2b11fd0b089879efa1394a3129d0c0e1f6
    }
}
