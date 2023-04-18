using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ProductChat.API.Models;

namespace ProductChat.API.Hubs
{
    public class ProductHub:Hub<IProductHub>
    {
        public async Task SendProduct(Product p)
        {
            await Clients.All.RecieveProduct(p);
        }
    }
}
