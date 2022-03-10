﻿using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Business.Utilities;
using Restaurant.Business.ViewModels.Team;
using Restaurant.Core.Models;
using Restaurant.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.UI.Areas.admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;
        private string _errorMessage;
        private IWebHostEnvironment _env;

        public TeamController(AppDbContext context,
                              IWebHostEnvironment env,
                              IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Teams
                                .Include(x => x.Position)
                                .ToList());
        }
        public async Task<IActionResult> Create()
        {
            await GetSelectedItemAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamCreateVM teamCreate)
        {
            if (!ModelState.IsValid) return View();
            if (!CheckImageValid(teamCreate.Photo, "image/", 200))
            {
                ModelState.AddModelError("Photo", _errorMessage);
                return View(teamCreate);
            }
            string fileName = await Extension.SaveFileAsync(teamCreate.Photo, _env.WebRootPath, "assets/img");
            Team team = new Team
            {
                FullName = teamCreate.FullName,
                PositionId = teamCreate.PositionId,
                Image = fileName
            };
            await _context.AddAsync(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool CheckImageValid(IFormFile file, string type, int size)
        {
            if (!Extension.CheckSize(file, size))
            {
                _errorMessage = "The size of this photo is 200";
                return false;
            }
            if (!Extension.CheckType(file, type))
            {
                _errorMessage = "The type is not correct";
                return false;
            }
            return true;
        }
        public async Task<IActionResult> Update(int id)
        {
            Team dbTeam = _context.Teams.Where(x => x.Id == id).FirstOrDefault();
            if (dbTeam is null) return NotFound();
            UpdateTeamVM team = _mapper.Map<UpdateTeamVM>(dbTeam);
            await GetSelectedItemAsync();
            return View(team);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, UpdateTeamVM updateTeam)
        {
            if (!ModelState.IsValid) return View();
            Team dbTeam = _context.Teams.Where(x => x.Id == id).FirstOrDefault();
            bool isCurrentName = dbTeam.FullName.Trim().ToLower() == updateTeam.FullName.ToLower().Trim();
            if (!isCurrentName)
            {
                dbTeam.FullName = updateTeam.FullName;
            }
            bool isCurrentPosition = dbTeam.PositionId == updateTeam.PositionId;
            if (!isCurrentPosition)
            {
                dbTeam.PositionId = updateTeam.PositionId;
            }
            if (updateTeam.Photo != null)
            {
                if (!CheckImageValid(updateTeam.Photo, "image/", 200))
                {
                    ModelState.AddModelError("Photo", _errorMessage);
                    return View(updateTeam);
                }
                Helper.RemoveFile(_env.WebRootPath, "assets/img", dbTeam.Image);
                string fileName = await Extension.SaveFileAsync(updateTeam.Photo, _env.WebRootPath, "assets/img");
                dbTeam.Image = fileName;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Team dbTeam = _context.Teams.Where(x => x.Id == id).FirstOrDefault();
            if (dbTeam is null) return NotFound();
            Helper.RemoveFile(_env.WebRootPath, "assets/img", dbTeam.Image);
            _context.Teams.Remove(dbTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private async Task GetSelectedItemAsync()
        {
            ViewBag.Position = new SelectList(await _context.Positions
                                                            .ToListAsync(), "Id", "Name");
        }
    }
}
