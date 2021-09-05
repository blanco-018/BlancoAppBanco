using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;

namespace AppBanco
{
    interface INotificable
    {
        public void SendNotification(User receiver, Notification notification);
        
        
    }
}
