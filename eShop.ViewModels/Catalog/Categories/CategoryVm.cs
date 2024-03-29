﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Catalog.Categories
{
    public class CategoryVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
        public string SeoAlias { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
    }
}