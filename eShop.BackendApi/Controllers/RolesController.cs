using eShop.Application.System.Roles;
using eShop.ViewModels.Catalog.Categories;
using eShop.ViewModels.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace eShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var role = await _roleService.GetById(id);
            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _roleService.Create(request);
            if (!result.IsSuccessed)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut("{roleId}")]
        public async Task<IActionResult> update([FromRoute] Guid roleId, [FromBody] RoleUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            request.Id = roleId;
            var result = await _roleService.Update(request);
            if (!result.IsSuccessed)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{roleId}")]
        public async Task<IActionResult> Delete(Guid roleId)
        {
            var result = await _roleService.Delete(roleId);
            if (!result.IsSuccessed)
                return BadRequest();
            return Ok();
        }
    }
}