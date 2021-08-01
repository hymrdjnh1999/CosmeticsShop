using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    public class GetBannerPagingRequest : QueryParamRequest
    {
        public string Keyword { get; set; }
    }
}
