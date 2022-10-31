using Accessories.Domain.EntityCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.Models
{
    public class BillEntity : BaseEntity
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public string? ResponseAPI { get; set; }
        public List<ProductEntity> Products { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}
