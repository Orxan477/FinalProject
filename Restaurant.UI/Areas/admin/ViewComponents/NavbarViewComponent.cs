﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurant.UI.Areas.admin.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
