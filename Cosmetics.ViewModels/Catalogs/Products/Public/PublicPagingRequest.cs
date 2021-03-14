using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products.Public
{
    public class PublicPagingRequest : QueryParamRequest
    {
        public int? CategoryId { get; set; }
    }
}
