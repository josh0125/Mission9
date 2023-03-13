﻿using Microsoft.AspNetCore.Mvc;
using Mission9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket { get; set; }

        public CartSummaryViewComponent(Basket temp)
        {
            basket = temp;
        }
       
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}