﻿using Acrelec.SCO.Core.Interfaces;
using Acrelec.SCO.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acrelec.SCO.Core.Managers
{
    public class OrderManager : IOrderManager
    {
        private IItemsProvider _itemsProvider { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public OrderManager(IItemsProvider itemsProvider)
        {
            _itemsProvider = itemsProvider;
        }

        //todo - implement interface knowing that it has to call the REST API described in readme.txt file 
        public Task<string> InjectOrderAsync(Order orderToInject)
        {
            Task<string> placeholder = new Task<string>(() => { return "abcd"; });
            return placeholder;
        }

    }
}
