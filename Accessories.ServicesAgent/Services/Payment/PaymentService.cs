using Accessories.Data.Context;
using Accessories.Domain.Models;
using Accessories.Infrastructure.Interfaces.Payment;
using Accessories.Infrastructure.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.ServicesAgent.Services.Payment
{
    public class PaymentService : BaseService, IPaymentService
    {
        public PaymentService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper) : base(dbContextFactory, mapper)
        {

        }
        
    }
}
