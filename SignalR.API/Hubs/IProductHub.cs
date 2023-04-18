using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductChat.API.Models;

namespace ProductChat.API.Hubs
{
    public interface IProductHub
    {
        Task RecieveProduct(Product p);
        
    }
}
