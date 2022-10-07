using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acrelec.SCO.Server.Models
{
    public class Order
    {
        public int Id { get; set; }        
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
