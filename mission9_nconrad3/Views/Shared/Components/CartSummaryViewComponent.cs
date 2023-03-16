using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mission9_nconrad3.Models;
using Microsoft.AspNetCore.Mvc;

namespace mission9_nconrad3.Views.Shared.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket cartService)
        {
            basket = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
