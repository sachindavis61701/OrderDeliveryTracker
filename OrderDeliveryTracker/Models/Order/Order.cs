using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDeliveryTracker.Models.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderStatus { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string ModifiedBy { get; set; }
    }
}
