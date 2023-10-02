using eShop.Data.Entities;
using eShop.ViewModels.Common;
using eShop.ViewModels.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<ApiResult<bool>> Create(RoleCreateRequest request)
        {
            var result = await _roleManager.CreateAsync(new AppRole()
            {
                Name = request.Name,
                Description = request.Description
            });
            return new ApiSuccessResult<bool>(result.Succeeded);
        }

        public async Task<ApiResult<bool>> Update(RoleUpdateRequest request)
        {
            var result = await _roleManager.FindByIdAsync(request.Id.ToString());
            if (result == null) return new ApiErrorResult<bool>("Không tìm thấy role");

            result.Name = request.Name;
            result.Description = request.Description;

            var updateResult = await _roleManager.UpdateAsync(result);
            return new ApiSuccessResult<bool>(updateResult.Succeeded);
        }

        public async Task<ApiResult<List<RoleVm>>> GetAll()
        {
            var roles = await _roleManager.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToListAsync();

            return new ApiSuccessResult<List<RoleVm>>(roles);
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            var result = await _roleManager.FindByIdAsync(id.ToString());
            if (result == null) return new ApiErrorResult<bool>("Không tìm thấy role");

            var deleteResult = await _roleManager.DeleteAsync(result);
            return new ApiSuccessResult<bool>(deleteResult.Succeeded);
        }

        public async Task<ApiResult<RoleVm>> GetById(Guid id)
        {
            var role = await _roleManager.Roles.Where(x => x.Id == id).Select(x => new RoleVm()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).FirstOrDefaultAsync();

            return new ApiSuccessResult<RoleVm>(role);
        }
    }
}