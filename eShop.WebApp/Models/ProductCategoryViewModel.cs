using eShop.ViewModels.Catalog.Categories;
using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;

namespace eShop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}