using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Orders
{
    public class OrderService : IOrderService
    {
        private readonly CosmeticsDbContext _context;
        public OrderService(CosmeticsDbContext context)
        {
            _context = context;
        }
        public async Task<PageResponse<OrderViewModel>> GetAll(GetOrderRequest request)
        {
            var test = from o in _context.Orders select o;

            var query = from o in _context.Orders select o;

            if (!String.IsNullOrEmpty(request.KeyWord))
            {
                query = query.Where(x => x.Id.ToString() == request.KeyWord ||
                x.ShipAddress.Contains(request.KeyWord) ||
                x.ShipPhoneNumber.Contains(request.KeyWord));
            }
            var pageIndex = request.PageIndex;
            var pageSize = request.PageSize;
            var count = await query.CountAsync();

            var orders = await query.Select(x => new OrderViewModel()
            {
                Id = x.Id,
                OrderDate = x.OrderDate,
                ShipAddress = x.ShipAddress,
                ShipEmail = x.ShipEmail ?? "",
                ShipName = x.ShipName,
                Status = x.Status,
                UserId = x.UserId,
                ShipPhoneNumber = x.ShipPhoneNumber,
            }).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();


            foreach (var item in orders)
            {
                var products = from o in orders
                               join od in _context.OrderDetails on o.Id equals od.OrderId
                               join p in _context.Products on od.ProductId equals p.Id
                               where o.Id == item.Id
                               select new { p, od };
                var productInOrders = products.Select(x => x.p).ToList();
                item.ProductQuantity = productInOrders.Count();
                item.Price = productInOrders[0].Price;
            }

            var pageResponse = new PageResponse<OrderViewModel>()
            {
                TotalRecords = count,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Items = orders
            };


            return pageResponse;
        }

        public async Task<OrderViewModel> GetById(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            var orderViewModel = new OrderViewModel()
            {
                Id = id,
                OrderDate = order.OrderDate,
                Price = order.Price,
                ShipName = order.ShipName,
                ShipAddress = order.ShipAddress,
                ShipEmail = order.ShipEmail,
                Status = order.Status,
                UserId = order.UserId,
                ShipPhoneNumber = order.ShipPhoneNumber,
            };
            //var productCount = await _context.OrderDetails.Where(x => x.OrderId == id).Include(x => x.ProductId).
            return orderViewModel;
        }
        public async Task<List<Product>> GetOrderProducts(int orderid)
        {
            var query = from od in _context.OrderDetails
                        where od.OrderId == 1
                        join p in _context.Products on od.ProductId equals p.Id
                        select p;
            var products = await query.ToListAsync();

            return products;
        }

    }
}
