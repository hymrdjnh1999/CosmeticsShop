using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products
{
    public class GetProductRequest : QueryParamRequest
    {
        public string Keyword { get; set; }
        public int? CategoryId { get; set; }
        public decimal? PriceStart { get; set; }
        public decimal? PriceEnd { get; set; }
        public string SortPrice { get; set; }
        public int? Gender { get; set; }
    }
}
