using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Orders
{
    public class ClientOrderViewModel
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string Note { get; set; }
        public string ShipPhoneNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
    }
}
