using Azure.Core;
using Azure;
using eShop.Data.Enums;
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
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> CreateOrder(CheckoutRequest request)
        {
            return await PostAsync<int>("/api/orders", request);
        }

        public async Task<List<OrderVm>> GetAll()
        {
            return await GetListAsync<OrderVm>("/api/orders");
        }

        public async Task<OrderVm> GetById(int id, string languageId)
        {
            return await GetAsync<OrderVm>($"/api/orders/{id}/{languageId}");
        }

        public async Task<bool> UpdateStatus(int orderId, OrderStatus status)
        {
            var sessions = _httpContextAccessor
              .HttpContext
              .Session
              .GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.PutAsync($"/api/orders/{orderId}/handle/{status}", null);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}