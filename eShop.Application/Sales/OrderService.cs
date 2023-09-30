using eShop.Data.EF;
using eShop.Data.Entities;
using eShop.Data.Enums;
using eShop.ViewModels.Common;
using eShop.ViewModels.Sales;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Sales
{
    public class OrderService : IOrderService
    {
        private readonly EShopDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderService(EShopDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<int> Create(CheckoutRequest request)
        {
            var orderDtails = new List<OrderDetail>();
            request.OrderDetails.ForEach(x => orderDtails.Add(new OrderDetail()
            {
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                Price = x.Price,
            }));

            var checkout = new Order()
            {
                ShipName = request.Name,
                OrderDate = DateTime.Now,
                ShipAddress = request.Address,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                OrderDetails = orderDtails,
                Status = OrderStatus.InProgress
            };

            _context.Orders.Add(checkout);

            await _context.SaveChangesAsync();
            return checkout.Id;
        }

        public Task<int> Delete(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDetailVm>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}