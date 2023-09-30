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
    }
}