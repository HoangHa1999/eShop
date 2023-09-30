using eShop.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Sales
{
    public interface IOrderService
    {
        Task<List<OrderDetailVm>> GetAll();

        Task<int> Create(CheckoutRequest request);

        Task<int> Delete(int orderId);
    }
}