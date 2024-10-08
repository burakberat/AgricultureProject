﻿using AgricultureBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace AgriculturePresentation.ViewComponents
{
    public class _SocialMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialMediaPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {            
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
    }
}
