using eShop.Data.Enums;
using eShop.ViewModels.Common;
using eShop.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<int>> CreateOrder(CheckoutRequest request);

        Task<List<OrderVm>> GetAll();

        Task<OrderVm> GetById(int id, string languageId);

        Task<bool> UpdateStatus(int orderId, OrderStatus status);
    }
}