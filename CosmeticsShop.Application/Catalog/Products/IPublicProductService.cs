using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Public;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResponse<ProductViewModel>> GetAll(PublicPagingRequest request);
    }
}
