using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Herramientas
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Clients.All.hello();
            //Clients.All.addNewMessageToPage(name, message);
            Clients.All.broadcastMessage(name, message);
        }
    }
}