using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;

namespace AppBanco.Services
{
    class BankAccountService
    {
        private Notification transactionNotif;
        private SmsService smsService = new SmsService();
        public void Transaction(User sender, User receiver, decimal quantity)
        {
            string title = $"{sender.Name} ha enviado {quantity}$ a {receiver.Name}";
            string message = "Tranascción completada";
            sender.bankAccount.RemoveBalance(quantity);
            receiver.bankAccount.AddBalance(quantity);
            transactionNotif = new Notification(title, message);
            smsService.sendSms(sender, transactionNotif);
            smsService.sendSms(receiver, transactionNotif);
        }
    }
}
}
