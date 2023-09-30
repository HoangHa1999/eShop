using eShop.Application.Sales;
using eShop.ViewModels.Sales;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(
            IOrderService orderService)
        {
            _orderService = orderService;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var orders = await _orderService.GetAll();
        //    return Ok(orders);
        //}

        //[HttpGet("{id}/{languageId}")]
        //public async Task<IActionResult> GetById(string languageId, int id)
        //{
        //    var category = await _orderService.GetById(languageId, id);
        //    return Ok(category);
        //}

        [HttpPost]
        public async Task<IActionResult> Create(CheckoutRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var checkoutId = await _orderService.Create(request);
            if (checkoutId == 0)
            {
                return BadRequest();
            }

            return CreatedAtAction("checkout", new { checkoutId });
        }

        //[HttpDelete("{orderId}")]
        //[Authorize]
        //public async Task<IActionResult> Delete(int categoryId)
        //{
        //    var affectedResult = await _orderService.Delete(categoryId);
        //    if (affectedResult == 0)
        //        return BadRequest();
        //    return Ok();
        //}
    }
}