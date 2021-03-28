using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Name ")]
        public string Name { get; set; }
        [DisplayName("User Name ")]
        public string UserName { get; set; }
        [DisplayName("Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    }
}
