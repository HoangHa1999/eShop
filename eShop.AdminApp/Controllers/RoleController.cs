using eShop.ApiIntegration;
using eShop.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace eShop.AdminApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IRoleApiClient _roleApiClient;

        public RoleController(
            IConfiguration configuration,
            IRoleApiClient roleApiClient)
        {
            _configuration = configuration;
            _roleApiClient = roleApiClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var roles = _roleApiClient.GetAll();

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }

            return View(roles.Result.ResultObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _roleApiClient.CreateRole(request);
            if (result)
            {
                TempData["result"] = "Thêm mới quyền thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm quyền thất bại");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var result = await _roleApiClient.GetById(id);

            if (result.IsSuccessed)
            {
                var role = result.ResultObj;
                var updateRequest = new RoleUpdateRequest()
                {
                    Id = role.Id,
                    Name = role.Name,
                    Description = role.Description
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Update(RoleUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _roleApiClient.UpdateRole(request);
            if (result)
            {
                TempData["result"] = "Cập nhật quyền thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật quyền thất bại");
            return View(request);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(new RoleDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(RoleDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _roleApiClient.DeleteRole(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa quyền thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa quyền không thành công");
            return View(request);
        }
    }
}