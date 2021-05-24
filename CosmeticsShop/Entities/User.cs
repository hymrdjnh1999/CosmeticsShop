using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public DateTime Dob { get; set; }
        public string Name { get; set; }

    }
}
