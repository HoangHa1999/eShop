using eShop.ViewModels.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}