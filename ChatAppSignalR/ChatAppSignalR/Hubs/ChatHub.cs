using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatAppSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            // Calls SendMessage Javascript function
            Clients.All.SendMessage(message);
        }
    }
}

