using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class SelectItemDynamic<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
