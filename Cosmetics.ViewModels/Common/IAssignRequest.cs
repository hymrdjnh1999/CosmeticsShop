using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class IAssignRequest<T, Q>
    {
        public T Id;
        public List<SelectItemDynamic<Q>> ItemsRequest { get; set; }
    }
}
