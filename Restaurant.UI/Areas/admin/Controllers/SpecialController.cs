﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Business.ViewModels.Home.Special;
using Restaurant.Core.Models;
using Restaurant.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.UI.Areas.admin.Controllers
{
    [Area("Admin")]
    public class SpecialController : Controller
    {
        private IMapper _mapper;
        private AppDbContext _context;

        public SpecialController(AppDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.SpecialCount=_context.Specials.Count();
            return View(_context.Specials.Include(x => x.MenuImage).ToList());
        }
        public async Task<IActionResult> Create()
        {
            if (_context.Specials.Count() >= 5)
            {
                return BadRequest();
            }
            await GetSelectedItemAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUpdateSpecialVM createSpecial)
        {
            if (!ModelState.IsValid) return View();
            
            Product dbProduct = await _context.Products.Where(x => !x.IsDeleted && x.Id == createSpecial.ProductId).Include(x=>x.MenuImage).FirstOrDefaultAsync();
            if (dbProduct is null) return NotFound();
            bool isExistFoodName=_context.Specials.Any(x=>x.FoodName.Trim().ToLower()==
                                                                    dbProduct.Name.ToLower().Trim());
            if (isExistFoodName)
            {
                ModelState.AddModelError("FoodName", "Information about this product is available");
                return View(createSpecial);
            }
            Special special = new Special
            {
                FoodName = dbProduct.Name,
                InformationTabHead = createSpecial.InformationTabHead,
                InformationTabContent = createSpecial.InformationTabContent,
                InformationTabItalicContent = createSpecial.InformationTabItalicContent,
                MenuImageId = dbProduct.MenuImage.Id
            };
            await _context.Specials.AddAsync(special);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            Special dbSpecial = _context.Specials.Where(x => x.Id == id).FirstOrDefault();
            if (dbSpecial is null) return NotFound();
            CreateUpdateSpecialVM position = _mapper.Map<CreateUpdateSpecialVM>(dbSpecial);
            await GetSelectedItemAsync();
            return View(position);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CreateUpdateSpecialVM updateSpecialVM)
        {
            if (!ModelState.IsValid) return View();
            Special dbSpecial = _context.Specials.Where(x => x.Id == id).FirstOrDefault();
            Product dbProduct = await _context.Products.Where(x => !x.IsDeleted && x.Id == updateSpecialVM.ProductId)
                                                                            .Include(x => x.MenuImage).FirstOrDefaultAsync();
            if (dbProduct is null) return NotFound();
            bool isExistFoodNameContext = _context.Specials.Any(x => x.FoodName.Trim().ToLower() ==
                                                                             dbProduct.Name.ToLower().Trim());

            bool isExistFoodName = dbSpecial.FoodName.Trim().ToLower() == dbProduct.Name.Trim().ToLower();
            if (isExistFoodNameContext && !isExistFoodName)
            {
                ModelState.AddModelError("ProductId", "Information about this product is available");
                return View(updateSpecialVM);
            }
            
            bool isCurrentTabHead = dbSpecial.InformationTabHead.Trim().ToLower() ==
                                                                updateSpecialVM.InformationTabHead.Trim().ToLower();
            if(!isCurrentTabHead) dbSpecial.InformationTabHead = updateSpecialVM.InformationTabHead;

            bool isCurrentTabContent = dbSpecial.InformationTabContent.Trim().ToLower() ==
                                                               updateSpecialVM.InformationTabContent.Trim().ToLower();
            if (!isCurrentTabContent) dbSpecial.InformationTabContent = updateSpecialVM.InformationTabContent;

            bool isCurrentTabItalicContent = dbSpecial.InformationTabItalicContent.Trim().ToLower() ==
                                                               updateSpecialVM.InformationTabItalicContent.Trim().ToLower();
            if (!isCurrentTabItalicContent) dbSpecial.InformationTabItalicContent = updateSpecialVM.InformationTabItalicContent;

            bool isCurrentProductId = dbSpecial.MenuImageId == dbProduct.MenuImage.Id;
            if (!isCurrentProductId) dbSpecial.MenuImageId = dbProduct.MenuImage.Id;

            if (!isCurrentTabItalicContent) dbSpecial.InformationTabItalicContent = updateSpecialVM.InformationTabItalicContent;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Special dbSpecial = _context.Specials.Where(x => x.Id == id).FirstOrDefault();
            if (dbSpecial is null) return NotFound();
            _context.Specials.Remove(dbSpecial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private async Task GetSelectedItemAsync()
        {
            ViewBag.Product = new SelectList(await _context.Products
                                                            .ToListAsync(), "Id", "Name");
        }
    }
}
