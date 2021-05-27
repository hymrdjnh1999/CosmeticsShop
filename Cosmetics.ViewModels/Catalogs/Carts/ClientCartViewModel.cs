using Cosmetics.ViewModels.Catalogs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Carts
{
    public class ClientCartViewModel
    {
        public int Id { get; set; }
        public Guid? ClientId { get; set; }
        public decimal CartPrice { get; set; }
        public List<ProductInCartViewModel> Products { get; set; } = new List<ProductInCartViewModel>();
    }
}
