using eShop.ViewModels.System.Users;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using eShop.ViewModels.Common;
using Microsoft.Extensions.Configuration;

using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace eShop.ApiIntegration
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        public UserApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
             : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            return await PostAsync<string>("/api/users/authenticate", request);
        }

        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            return await GetAsync<ApiResult<UserVm>>($"/api/users/{id}");
        }

        public async Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request)
        {
            return await GetAsync<ApiResult<PagedResult<UserVm>>>($"/api/users/paging?pageIndex=" +
                $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<ApiResult<bool>> RegisterUser(RegisterRequest request)
        {
            return await PostAsync<bool>("/api/users", request);
        }

        public async Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
        {
            return await PutAsync<bool>($"/api/users/{id}", request);
        }

        public async Task<ApiResult<bool>> DeleteUser(Guid id)
        {
            var result = await DeleteAsync($"/api/users/{id}");
            if (result)
                return new ApiSuccessResult<bool>();
            return new ApiErrorResult<bool>();
        }

        public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
        {
            return await PutAsync<bool>($"/api/users/{id}/roles", request);
        }
    }
}