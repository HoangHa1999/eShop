﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Sales
{
    public class OrderDetailVm
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }
    }
}