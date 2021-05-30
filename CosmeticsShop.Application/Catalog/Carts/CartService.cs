using Cosmetics.ViewModels.Catalogs.Carts;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Carts
{
    public class CartService : ICartService
    {
        private readonly CosmeticsDbContext _context;
        public CartService(CosmeticsDbContext context)
        {
            _context = context;
        }
        public async Task<ClientCartViewModel> AddToCart(ClientCartViewModel request)
        {
            var cart = await _context.Carts.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (cart == null)
            {
                cart = new Cart()
                {
                    Id = request.Id,
                    DateCreated = DateTime.Now,
                    Price = request.Products.Sum(x => x.ProductPrice * x.Quantity),
                    Quantity = request.Products.Count,
                    ClientId = request.ClientId
                };
                _context.Carts.Add(cart);
                foreach (var item in request.Products)
                {
                    var productIncart = new ProductInCart()
                    {
                        CartId = cart.Id,
                        ProductId = item.Id,
                        ProductName = item.ProductName,
                        ProductPrice = item.ProductPrice,
                        Quantity = item.Quantity
                    };
                    _context.ProductInCarts.Add(productIncart);
                }
            }
            else
            {
                cart.Quantity = request.Products.Count;
                cart.Price = request.Products.Sum(x => x.ProductPrice * x.Quantity);
                cart.ClientId = request.ClientId;
                _context.Carts.Attach(cart);
            }
            await _context.SaveChangesAsync();
            return request;

        }

        public Task<ClientCartViewModel> UpdateCart(ClientCartViewModel request)
        {
            throw new NotImplementedException();
        }
    }
}
