using Accessories.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Data.Context
{
    public class AccessoriesDbContext : IdentityDbContext<UserEntity>

    {
        public AccessoriesDbContext(DbContextOptions<AccessoriesDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<BillEntity> Bills { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
