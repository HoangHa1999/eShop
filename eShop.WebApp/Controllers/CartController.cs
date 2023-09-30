using eShop.ApiIntegration;
using eShop.Utilities.Constants;
using eShop.ViewModels.Sales;
using eShop.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IOrderApiClient _orderApiClient;

        public CartController(IProductApiClient productApiClient, IOrderApiClient orderApiClient)
        {
            _productApiClient = productApiClient;
            _orderApiClient = orderApiClient;
        }

        public IActionResult Index()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            return View(currentCart);
        }

        public IActionResult Checkout()
        {
            return View(GetCheckoutViewModel());
        }

        [HttpPost]
        public IActionResult Checkout(CheckoutViewModel request)
        {
            var model = GetCheckoutViewModel();
            var orderDetails = new List<OrderDetailVm>();
            foreach (var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailVm()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                });
            }
            var checkoutRequest = new CheckoutRequest()
            {
                Address = request.CheckoutModel.Address,
                Name = request.CheckoutModel.Name,
                Email = request.CheckoutModel.Email,
                PhoneNumber = request.CheckoutModel.PhoneNumber,
                OrderDetails = orderDetails
            };
            var result = _orderApiClient.CreateOrder(checkoutRequest);
            if (result.Id != 0)
            {
                HttpContext.Session.Remove(SystemConstants.CartSession);
                TempData["SuccessMsg"] = "Order puschased successful";
            }
            else
            {
                TempData["FailedMsg"] = "Order puschased failed";
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult GetQuantityProduct()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            return Ok(currentCart.Count);
        }

        public async Task<IActionResult> AddToCart(int id, string languageId, int quantity = 1)
        {
            var product = await _productApiClient.GetById(id, languageId);

            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            if (currentCart.Any(x => x.ProductId == id))
            {
                currentCart.Find(x => x.ProductId == id).Quantity += quantity;
            }
            else
            {
                var cartItem = new CartItemViewModel()
                {
                    ProductId = id,
                    Description = product.Description,
                    Image = product.ThumbnailImage,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity
                };
                currentCart.Add(cartItem);
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        private CheckoutViewModel GetCheckoutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            var checkoutVm = new CheckoutViewModel()
            {
                CartItems = currentCart,
                CheckoutModel = new CheckoutRequest()
            };
            return checkoutVm;
        }
    }
}