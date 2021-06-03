using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Carts
{
    public class DeleteProductInCartRequest
    {
        public int ProductId { get; set; }
        public ClientCartViewModel Cart { get; set; }
    }
}
