using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(dynamic message)
        {

        }
    }
}
