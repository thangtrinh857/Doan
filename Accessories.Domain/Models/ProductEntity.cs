using Accessories.Domain.EntityCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.Models
{
    public class ProductEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }

    }
}
