using eShop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}