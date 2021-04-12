using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class PaginateRequest : QueryParamRequest
    {
        public string Keyword { get; set; }
    }
}
