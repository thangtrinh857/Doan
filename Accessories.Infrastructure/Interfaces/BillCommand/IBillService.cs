using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.Interfaces.BillCommand
{
    public interface IBillService
    {
        Task<bool> CreateBillAsync(int total, string responseApi, string userId);
    }
}
