using eShop.ViewModels.Common;
using eShop.ViewModels.System.Users;
using System.Threading.Tasks;

namespace eShopAdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}