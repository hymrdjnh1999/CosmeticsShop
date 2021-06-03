using Cosmetics.ViewModels.Catalogs.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Orders
{
    public class ClientCreateOrderViewModel
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public string ClientNote { get; set; }
        public Guid? ClientID { get; set; }
        public string Email { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhone { get; set; }
        public bool SaveShipInfo { get; set; }
        public decimal TotalPrice { get; set; }
        public ClientCartViewModel ClientCart { get; set; }
    }
}
