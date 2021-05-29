﻿using Cosmetics.ViewModels.Catalogs.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface ICartApiClient
    {
        Task<ClientCartViewModel> AddToCart(ClientCartViewModel request);
        Task<ClientCartViewModel> UpdateCart(ClientCartViewModel request);
    }
}