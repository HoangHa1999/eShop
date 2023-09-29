﻿using eShop.ViewModels.Sales;
using System.Collections.Generic;

namespace eShop.WebApp.Models
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public CheckoutRequest CheckoutModel { get; set; }
    }
}