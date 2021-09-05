using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;
using AppBanco.Interfaces;
using static AppBanco.Classes.Usertype;

namespace AppBanco.Services
{
    class UserService : IRegisterable, IAccountCreable
    {
        private EmailService emailService = new EmailService();
        public User Register(string name, string email, Usertype usertype)
        {
            if (!Validate(email))
                throw new Exception("Email inválido");

            var title = $"Bienvenido al banco, {name}!";
            var message = "Bienvenido al banco , tu cuenta está lista!";
            Notification registerNotification = new Notification(title, message);
            if (usertype.Equals(Usertype.client))
            {
                var client = new Client(name, email);
                emailService.sendEmail(client, registerNotification);
                return client;
            }
            else if (usertype.Equals(Usertype.employee))
            {

                var employee = new Employee(name, email);
                emailService.sendEmail(employee, registerNotification);
                return employee;
            }
            else
                throw new Exception("Ese tipo de usuario no está registrado");

        }

        internal object Register(string v1, string v2, Constants.UserType client)
        {
            throw new NotImplementedException();
        }

        public bool Validate(string email)
        {
            if (!email.Contains("@"))
                return false;

            return true;
        }

        public void CreateAccount(User user)
        {
            if (user.bankAccount == null)
                user.bankAccount = new BankAccount(user.Name);
            else
                Console.WriteLine("Ya tienes una cuenta en el banco");
        }


    }
}

