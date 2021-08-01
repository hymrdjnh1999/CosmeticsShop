using Cosmetics.ViewModels.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Ultilities
{
    public interface ISlideService
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
