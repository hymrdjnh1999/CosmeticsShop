using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products
{
    public class GetProductImageRequest : QueryParamRequest
    {
        public int ProductId { get; set; }
    }
}
