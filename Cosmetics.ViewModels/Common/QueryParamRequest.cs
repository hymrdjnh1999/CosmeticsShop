using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class QueryParamRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 5;
        public object Keyword { get; set; }
    }
}
