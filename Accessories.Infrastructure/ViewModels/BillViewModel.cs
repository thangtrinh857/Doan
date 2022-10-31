using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.ViewModels
{
	public class BillViewModel
	{
		public int? Total { get; set; }
		public List<CartProductViewModel> CartProducts { get; set; }
	}
}
