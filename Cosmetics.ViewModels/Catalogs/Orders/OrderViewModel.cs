using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Orders
{
    public class OrderViewModel
    {
        public int Id { set; get; }
        [DisplayName("Ngày tạo")]
        public DateTime OrderDate { set; get; }
        [DisplayName("SL sản phẩm")]
        public int ProductQuantity { get; set; }
        [DisplayName("Giá trị")]
        public decimal Price { get; set; }
        public List<Product> OrderProducts { get; set; } = new List<Product>();
        public Guid UserId { set; get; }
        [DisplayName("Nguời nhận")]
        public string ShipName { set; get; }
        [DisplayName("Địa chỉ nhận")]
        public string ShipAddress { set; get; }
        [DisplayName("Email")]
        public string ShipEmail { set; get; }
        [DisplayName("Số điện thoại")]
        public string ShipPhoneNumber { set; get; }
        [DisplayName("Trạng thái")]
        public OrderStatus Status { set; get; }
    }
}
