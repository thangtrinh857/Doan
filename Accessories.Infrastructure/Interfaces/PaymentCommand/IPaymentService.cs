using Accessories.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.Interfaces.PaymentCommand
{
    public interface IPaymentService 
    {
        string PaymentByVNPayGateway(int total);
        string PaymentByMomoGateway(BillViewModel bill);
    }
}
