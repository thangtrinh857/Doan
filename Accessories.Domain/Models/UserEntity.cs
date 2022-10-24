using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.Models
{
    public class UserEntity : IdentityUser
    {
        public bool IsActived { get; set; } = false ;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string Address { get; set; }
    }
}
