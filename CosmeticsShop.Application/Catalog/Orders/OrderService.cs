using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private IQueryable<Order> GetQueryOrders(SelectListItem item, IQueryable<Order> query, string keyWord)
        {
            switch (item.Value)
            {
                case "id":
                    return query.Where(x => x.Id.ToString() == keyWord);
                case "phone":
                    return query.Where(x => x.ShipPhoneNumber.Contains(keyWord));
                case "shipname":
                    return query.Where(x => x.ShipName.Contains(keyWord));
                default:
                    return query;
            }
        }
        public async Task<PageResponse<OrderViewModel>> GetAll(GetOrderRequest request)
        {
            var query = from o in _context.Orders select o;

            var category = OrderCategorySearch.Categories.Where(x => x.Value == request.Type).FirstOrDefault();
            if (!String.IsNullOrEmpty(request.KeyWord) && category == null)
            {
                query = query.Where(x => x.Id.ToString() == request.KeyWord ||
                x.Id.ToString() == request.KeyWord ||
                x.ShipPhoneNumber.Contains(request.KeyWord) || x.ShipName.Contains(request.KeyWord));
            }
            if (category != null && request.KeyWord != null)
            {
                query = GetQueryOrders(category, query, request.KeyWord);
            }
            var pageIndex = request.PageIndex;
            var pageSize = request.PageSize;
            var count = await query.CountAsync();

            var orders = await query.Select(x => new OrderViewModel()
            {
                Id = x.Id,
                Price = x.Price,
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
            var query = from o in _context.Orders where o.Id == id select o;
            var order = await query.FirstOrDefaultAsync();
            if (order == null) return null;
            var productQuery = from od in _context.OrderDetails
                               where od.OrderId == id
                               join p in _context.Products on od.ProductId equals p.Id
                               select p;
            var user = await _context.Users.Where(x => x.Id == order.UserId).FirstOrDefaultAsync();

            var orderViewModel = new OrderViewModel()
            {
                Id = id,
                OrderDate = order.OrderDate,
                Price = order.Price,
                ShipName = order.ShipName,
                ShipAddress = order.ShipAddress,
                ShipEmail = order.ShipEmail,
                Status = order.Status,
                UserNameOrder = user.Name,
                ShipPhoneNumber = order.ShipPhoneNumber,
                ProductQuantity = await productQuery.CountAsync()
            };
            return orderViewModel;
        }
        public async Task<List<OrderProductViewModel>> GetOrderProducts(int orderid)
        {
            var query = from od in _context.OrderDetails
                        where od.OrderId == orderid
                        join p in _context.Products on od.ProductId equals p.Id
                        select new { p, od };

            var products = await query.Select(x => new OrderProductViewModel()
            {
                Id = x.od.ProductId,
                Name = x.p.Name,
                Price = x.od.Price,
                Quantity = x.od.Quantity
            }).ToListAsync();

            return products;
        }

        public async Task<bool> UpdateStatus(OrderViewModel request)
        {
            var order = await _context.Orders.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (order == null) return false;

            order.Status = request.Status;

            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
