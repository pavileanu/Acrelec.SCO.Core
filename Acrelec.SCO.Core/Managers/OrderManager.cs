using Acrelec.SCO.Core.Interfaces;
using Acrelec.SCO.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Acrelec.SCO.Core.Model.RestExchangedMessages;
using System.Net.Http.Json;

namespace Acrelec.SCO.Core.Managers
{
    public class OrderManager : IOrderManager
    {
        private IItemsProvider _itemsProvider { get; set; }

        private readonly HttpClient client = new HttpClient();
        private readonly string APIserver = "http://localhost:48327";

        /// <summary>
        /// constructor
        /// </summary>
        public OrderManager(IItemsProvider itemsProvider)
        {
            _itemsProvider = itemsProvider;
            client.BaseAddress = new Uri(APIserver);
        }

        //todo - implement interface knowing that it has to call the REST API described in readme.txt file 
        public async Task<string> InjectOrderAsync(Order orderToInject, Customer customer)
        {
            InjectOrderRequest orderRequest = new InjectOrderRequest()
            {
                Order = orderToInject,
                Customer = customer
            };

            var response = await client.PostAsJsonAsync("/api-sco/v1/injectorder", orderRequest);

            InjectOrderResponse orderResponse = await response.Content.ReadFromJsonAsync<InjectOrderResponse>();

            return Convert.ToString(orderResponse.orderNumber);
        }

        public async Task<bool> IsOrderServiceOnlineAsync()
        {
            var availabilityResponse = await client.GetFromJsonAsync<CheckAvailabilityResponse>("/api-sco/v1/availability");

            return availabilityResponse.CanInjectOrders;
        }
    }
}
