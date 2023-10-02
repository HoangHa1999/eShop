using eShop.ViewModels.Catalog.Categories;
using eShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);

        Task<ApiResult<int>> CreateCategory(CategoryCreateRequest request);

        Task<ApiResult<int>> UpdateCategory(CategoryUpdateRequest request);

        Task<bool> DeleteCategory(int id);
    }
}