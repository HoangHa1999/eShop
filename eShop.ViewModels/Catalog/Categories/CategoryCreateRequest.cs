using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShop.ViewModels.Catalog.Categories
{
    public class CategoryCreateRequest
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public int? ParentId { get; set; }

        public string LanguageId { set; get; }

        public string SeoDescription { set; get; }

        public string SeoTitle { set; get; }

        public string SeoAlias { set; get; }
    }
}