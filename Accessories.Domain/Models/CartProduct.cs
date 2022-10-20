using Accessories.Domain.EntityCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.Models
{
    public class CartProduct : BaseEntity
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [ForeignKey(nameof(BillEntity))]
        public int BillId { get; set; }
        public int Quantity { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}
