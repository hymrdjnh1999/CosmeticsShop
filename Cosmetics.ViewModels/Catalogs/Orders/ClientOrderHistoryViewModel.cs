using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Orders
{
    public class ClientOrderHistoryViewMode
    {
        public int Id { set; get; }
        public Guid ClientId { set; get; }
        public DateTime OrderDate { set; get; }
        public decimal Total { set; get; }
        public OrderStatus Status { set; get; }
    }
}
