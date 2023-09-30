using eShop.Data.EF;
using eShop.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eShop.Data.Entities;
using eShop.Data.Enums;
using eShop.Utilities.Exceptions;

namespace eShop.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly EShopDbContext _context;

        public CategoryService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Status = Status.Active,
                CategoryTranslations = new List<CategoryTranslation>()
                {
                    new CategoryTranslation()
                    {
                        Name = request.Name,
                        SeoDescription = request.SeoDescription,
                        SeoTitle = request.SeoTitle,
                        SeoAlias = request.SeoAlias,
                        LanguageId = request.LanguageId
                    }
                }
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }

        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId
            }).ToListAsync();
        }

        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId && c.Id == id
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId
            }).FirstOrDefaultAsync();
        }

        public async Task<int> Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category == null) throw new EShopException($"Cannot find a category: {categoryId}");

            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }
    }
}