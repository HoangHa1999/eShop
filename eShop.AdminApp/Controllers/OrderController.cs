using eShop.ApiIntegration;
using eShop.Data.Enums;
using eShop.Utilities.Constants;
using eShop.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace eShop.AdminApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;

        public OrderController(IOrderApiClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderApiClient.GetAll();

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(orders);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var languageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);
            var order = _orderApiClient.GetById(id, languageId);
            return View(order.Result);
        }

        [HttpPost]
        public IActionResult Handle(int OrderId, OrderStatus Status, string returnUrl)
        {
            _orderApiClient.UpdateStatus(OrderId, Status);
            TempData["result"] = "Cập nhật trạng thái đơn hàng thành công";
            return LocalRedirect(returnUrl);
        }
    }
}