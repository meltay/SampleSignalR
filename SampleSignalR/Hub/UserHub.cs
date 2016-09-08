using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SampleSignalR
{
    [HubName("UserHub")]
    public class UserHub : Hub
    {
        [HubMethodName("GetUser")]
        public void GetUser(string userName, int userAge, int userSalary)
        {
            Clients.All.addUser(userName,userAge,userSalary);
        }
    }
}