using Cosmetics.ViewModels.Catalogs.Orders;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Clients
{
    public class ClientViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Avatar { get; set; }
        public IFormFile NewAvatar { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderQuanttity { get; set; }
        public List<OrderViewModel> Orders { get; set; }


    }
}
