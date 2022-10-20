using Accessories.Domain.EntityCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.Models
{
    public class CategoryEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
