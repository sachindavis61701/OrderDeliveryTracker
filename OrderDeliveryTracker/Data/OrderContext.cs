using Microsoft.EntityFrameworkCore;
using OrderDeliveryTracker.Models.Order;
using System;

namespace OrderDeliveryTracker.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
          : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
    }
}
