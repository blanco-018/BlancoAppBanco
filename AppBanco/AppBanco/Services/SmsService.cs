using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;
using AppBanco.Interfaces;

namespace AppBanco.Services
{
    class SmsService :INotificable
    {
        public string sendNotification(User receiver, Notification notification)
        {
            return $"Para: {receiver}. {notification.Title} Mensaje: {notification.Message}";
        }

        public void sendSms(User receiver, Notification notification)
        {
            Console.WriteLine(sendNotification(receiver, notification));
        }
    }
}
