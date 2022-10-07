using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Acrelec.SCO.Core.Model.RestExchangedMessages
{
    public class InjectOrderResponse
    {
        /// <summary>
        /// order number assigned by the POS system
        /// </summary>
        public int orderNumber { get; set; }

        public static implicit operator InjectOrderResponse(HttpResponseMessage v)
        {
            throw new NotImplementedException();
        }
    }
}
