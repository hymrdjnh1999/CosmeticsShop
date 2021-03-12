﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Enums
{
    public enum OrderStatus
    {
        InProgress = 1,
        Confirmed,
        Shipping,
        Success,
        Canceled
    }
}
