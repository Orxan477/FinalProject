﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data.DAL;
using System.Linq;

namespace Restaurant.UI.Areas.admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Teams
                                .Include(x=>x.Position)
                                .ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create()
        //{

        //}
    }
}
