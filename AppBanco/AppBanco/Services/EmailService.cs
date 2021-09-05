using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;
using AppBanco.Interfaces;

namespace AppBanco.Services
{
     class EmailService : INotificable
    {
        public string sendNotification(User receiver, Notification notif)
        {
            return $"Para: {receiver.Email} {notif.Title}\n{notif.Message}";
        }

        public void sendEmail(User receiver, Notification notif)
        {
            Console.Write(sendNotification(receiver, notif));
        }

    }
}
