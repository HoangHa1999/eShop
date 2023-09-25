using eShop.ApiIntegration;
using eShop.ViewModels.Catalog.Products;
using eShop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eShop.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index(string culture)
        {
            var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            {
                LanguageId = culture,
            });
            return View(new ProductViewModel()
            {
                Products = products.Items
            }); ;
        }

        public async Task<IActionResult> Detail(int id, string culture)
        {
            var product = await _productApiClient.GetById(id, culture);
            return View(new ProductDetailViewModel()
            {
                Product = product
            });
        }

        public async Task<IActionResult> Category(int id, string culture)
        {
            var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            {
                CategoryId = id,
                LanguageId = culture,
            });
            return View(new ProductCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(culture, id),
                Products = products
            }); ;
        }
    }
}