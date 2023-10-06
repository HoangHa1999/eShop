using eShop.Application.Common;
using eShop.Data.EF;
using eShop.Data.Entities;
using eShop.Data.Enums;
using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Sales;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
                Total = request.OrderDetails.Sum(x => x.Quantity * x.Price),
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

        public async Task<List<OrderVm>> GetAll()
        {
            var query = from order in _context.Orders
                        select new { order };
            var data = await query.Select(x =>
            new OrderVm()
            {
                Id = x.order.Id,
                Name = x.order.ShipName,
                Address = x.order.ShipAddress,
                Email = x.order.ShipEmail,
                PhoneNumber = x.order.ShipPhoneNumber,
                Total = x.order.Total,
                OrderDate = x.order.OrderDate,
                OrderStatus = x.order.Status,
            }
            ).ToListAsync();

            return data;
        }

        public async Task<OrderVm> GetById(string languageId, int id)
        {
            var order = _context.Orders.Where(x => x.Id == id).FirstOrDefault();
            var orderDetails = _context.OrderDetails.Where(x => x.OrderId == id).ToList();

            var productTranslations = await (from p in _context.Products
                                             join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                                             where pt.LanguageId == languageId
                                             select new { p.Id, pt.Name }).ToListAsync();

            var oderDetailsViewModel = new List<OrderDetailVm>();
            foreach (var item in orderDetails)
            {
                if (productTranslations.Any(x => x.Id == item.ProductId))
                {
                    var orderDetailVm = new OrderDetailVm()
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = item.Price,
                        Name = productTranslations.Where(x => x.Id == item.ProductId).FirstOrDefault().Name
                    };
                    oderDetailsViewModel.Add(orderDetailVm);
                }
            }

            var orderViewModel = new OrderVm()
            {
                Id = order.Id,
                Name = order.ShipName,
                Address = order.ShipAddress,
                Email = order.ShipEmail,
                PhoneNumber = order.ShipPhoneNumber,
                Total = order.Total,
                OrderDate = order.OrderDate,
                OrderStatus = order.Status,
                OrderDetails = oderDetailsViewModel
            };

            return orderViewModel;
        }

        public async Task<int> UpdateStatus(int orderId, OrderStatus status)
        {
            var order = await _context.Orders.FindAsync(orderId);
            order.Status = status;
            await _context.SaveChangesAsync();
            return order.Id;
        }
    }
}