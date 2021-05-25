﻿using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class Banner
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public long FileSize { get; set; }
        public bool IsOutstanding { get; set; }
    }
}
