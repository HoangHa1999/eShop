using eShop.Utilities.Constants;
using eShop.ViewModels.Common;
using eShop.ViewModels.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public class OrderApiClient : BaseApiClient, IOrderApiClient
    {
        public OrderApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<int>> CreateOrder(CheckoutRequest request)
        {
            return await PostAsync<int>("/api/orders", request);
        }
    }
}