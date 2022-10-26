using Accessories.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Cover { get; set; }
        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
