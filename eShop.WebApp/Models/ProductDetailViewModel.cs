using eShop.ViewModels.Catalog.Categories;
using eShop.ViewModels.Catalog.ProductImages;
using eShop.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace eShop.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}