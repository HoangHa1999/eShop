using eShop.ViewModels.Common;
using eShop.ViewModels.System.Roles;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {
        public RoleApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<List<RoleVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<RoleVm>>>("/api/roles");
        }
    }
}