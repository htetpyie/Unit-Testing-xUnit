using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting.Features.Order
{
    public class OrderService : IOrderService
    {
        public bool IsOrderPlaced(Order order)
        {
            return order != null;
        }
    }

    public class Order
    {
         public Guid OrderId { get; set; }
         public string OrderCode { get; set; }
         public int Qty { get; set; }
    }
}
