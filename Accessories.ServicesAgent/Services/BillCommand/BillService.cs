using Accessories.Data.Context;
using Accessories.Domain.Models;
using Accessories.Infrastructure.Interfaces.BillCommand;
using Accessories.Infrastructure.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace Accessories.ServicesAgent.Services.BillCommand
{
    public class BillService : BaseService, IBillService
    {
        public BillService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper) : base(dbContextFactory, mapper)
        {
        }

        public async Task<bool> CreateBillAsync(int total, string responseApi,string userId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var bill = new BillEntity();
            bill.Total = total;
            bill.CreatedBy = userId;
            bill.CreatedDate = DateTime.Now;
            bill.UpdatedDate = DateTime.Now;
            bill.UpdatedBy = userId;
            bill.IsActive = true;
            bill.ResponseAPI = responseApi;
            var result = context.Bills.Add(bill);
            if (result == null) return false;
            await context.SaveChangesAsync();
            return true;
        }
    }
}
