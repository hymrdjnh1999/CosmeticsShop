﻿using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool IsOutstanding { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }

    }
}
