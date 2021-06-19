using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Orders
{
    public class GetOrderRequest : QueryParamRequest
    {
        public string KeyWord { get; set; }
        public string Type { get; set; }
        public string DateCreate { get; set; }
    }
}
