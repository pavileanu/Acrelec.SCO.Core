using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acrelec.SCO.Server.Dto
{
    public class RequestOrderDto
    {
        public OrderDto Order { get; set; }

        public CustomerDto Customer { get; set; }
    }
}
