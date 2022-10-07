using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acrelec.SCO.Server.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
