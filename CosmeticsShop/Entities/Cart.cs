using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ProductInCart> ProductInCarts { get; set; }
        public Client Client { get; set; }

    }
}
