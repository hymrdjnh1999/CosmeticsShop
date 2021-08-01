using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class ProductInCosmeticsCollection
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CosmeticsCollectionId { get; set; }
        public CosmeticsCollection CosmeticsCollection { get; set; }

    }
}
