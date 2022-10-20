using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Domain.EntityCommon
{
    public class BaseEntity
    {
        public DateTimeOffset CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
