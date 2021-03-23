using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class PageResponse<T> : PageResponseBase
    {
        public List<T> Items { get; set; }

    }
}
