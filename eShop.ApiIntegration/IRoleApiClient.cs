using eShop.ViewModels.Common;
using eShop.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();

        Task<bool> CreateRole(RoleCreateRequest request);

        Task<bool> UpdateRole(RoleUpdateRequest request);

        Task<bool> DeleteRole(Guid id);

        Task<ApiResult<RoleVm>> GetById(Guid id);
    }
}