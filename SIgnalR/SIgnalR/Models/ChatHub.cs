using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string timeStamp, string user, string message)
        {
            await Clients.All.SendAsync("RecieveMessage", timeStamp, user, message);
        }
    }
}
