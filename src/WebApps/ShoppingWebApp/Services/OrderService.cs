﻿using ShoppingWeApp.Extensions;
using ShoppingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingWebApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _client;

        public OrderService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName)
        {
            var response = await _client.GetAsync($"/Order/{userName}");

            return await response.ReadContentAs<List<OrderResponseModel>>();
        }
    }
}
