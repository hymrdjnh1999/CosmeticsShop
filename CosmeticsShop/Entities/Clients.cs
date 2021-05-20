using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class Clients
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public DateTime Dob { get; set; }
        public Status Status { get; set; }

    }
}
