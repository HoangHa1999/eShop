using eShop.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);

        Task<int> Create(CategoryCreateRequest request);

        Task<int> Update(CategoryUpdateRequest request);

        Task<int> Delete(int categoryId);
    }
}