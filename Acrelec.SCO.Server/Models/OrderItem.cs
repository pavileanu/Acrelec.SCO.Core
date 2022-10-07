using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acrelec.SCO.Server.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemCode { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}
