using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels
{
    public class CartProductViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? BillId { get; set; }
        public int Quantity { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public bool IsPaid { get; set; } = false;
    }
}
