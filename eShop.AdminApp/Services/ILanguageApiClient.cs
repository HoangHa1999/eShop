using eShop.ViewModels.Common;
using eShop.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.AdminApp.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}