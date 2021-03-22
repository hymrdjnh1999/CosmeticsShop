using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Users
{
    public class UpdateUserRequest
    {
        public Guid Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
