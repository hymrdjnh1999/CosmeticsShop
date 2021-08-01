using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class CosmeticsCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductInCosmeticsCollection> ProductInCosmeticsCollections { get; set; }
    }
}
