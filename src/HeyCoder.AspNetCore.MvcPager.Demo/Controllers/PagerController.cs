﻿using HeyCoder.AspNetCore.Mvc.Pager.Interface;
using Microsoft.AspNetCore.Mvc;



namespace HeyCoder.AspNetCore.MvcPager.Demo.Controllers
{
    public class PagerController : Controller
    {
        public IPagerOption PagerOption { get; }

        public PagerController(IPagerOption pagerOption)
        {
            PagerOption = pagerOption;
        }
        public IActionResult Index(int? pageIndex)
        {
            PagerOption.DataCount = 100;
            PagerOption.PageSize = 10;
            PagerOption.PageIndex = pageIndex ?? 1;
            ViewBag.PagerOption = PagerOption;
            return View();
        }

        public IActionResult BootStrap(int? pageIndex)
        {
            PagerOption.DataCount = 100;
            PagerOption.PageSize = 10;
            PagerOption.PageIndex = pageIndex ?? 1;
            ViewBag.PagerOption = PagerOption;
            return View();
        }
    }
}
