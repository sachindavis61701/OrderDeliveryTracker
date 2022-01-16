using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderDeliveryTracker.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDeliveryTracker.Data
{
    public class OrderContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public OrderContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
