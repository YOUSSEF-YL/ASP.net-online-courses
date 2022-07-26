﻿using ECOURSES.Data;
using ECOURSES.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace ECOURSES.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            

            return View(_db);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Teachers()
        {
            return View(_db);
        }

        public IActionResult Courses()
        {
            return View(_db);
        }


        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Login()
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


        public int Subscribers(int id)
        {
            // ApplicationDbContext db = new();
            var studentsc = _db;

            // var count = db.CourseStudent.Count();

            // var cout = students.Where(CourseID == id).cou

            int count = studentsc.CourseStudent.Count(CourseStudent => CourseStudent.CourseID == id);
            return count;

        }
    }
}