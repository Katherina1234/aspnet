using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab1_1.Models;
using Microsoft.EntityFrameworkCore;

namespace lab1_1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> About()
        {
            ViewBag.Trains = new List<Train> (await db.Trains.ToListAsync());
            return View(await db.Timetable.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Timetable user)
        {
            db.Timetable.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Order(Order user)
        {
            db.Orders.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Orderpage(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult Contact()
        {
            

            return View();
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
