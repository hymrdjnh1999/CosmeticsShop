﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class ProductInProductPrivateProperty
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ProductPrivateProperty ProductPrivateProperty { get; set; }
        public int ProductPrivatePropertyId { get; set; }
    }
}
