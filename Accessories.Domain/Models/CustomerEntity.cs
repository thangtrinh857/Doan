using Accessories.Domain.EntityCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.Models
{
    public class CustomerEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [ForeignKey(nameof(UserEntity))]
        public string UserId { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual UserEntity Users { get; set; }
    }
}
