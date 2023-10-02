using eShop.ViewModels.Common;
using eShop.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.System.Roles
{
    public interface IRoleService
    {
        Task<ApiResult<List<RoleVm>>> GetAll();

        Task<ApiResult<bool>> Create(RoleCreateRequest request);

        Task<ApiResult<bool>> Update(RoleUpdateRequest request);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<RoleVm>> GetById(Guid id);
    }
}