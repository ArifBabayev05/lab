using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Models;
using LessonReplay.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LessonReplay.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.ToListAsync();
            List<Slider> sliders = await _context.Sliders.ToListAsync();


            HomeVM homeVm = new HomeVM()
            {
                Sliders = sliders,
                Products = products
            };
            return View(model: homeVm);
        }
    }
}

