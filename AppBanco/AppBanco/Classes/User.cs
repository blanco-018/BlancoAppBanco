using System;
using System.Collections.Generic;
using System.Text;

namespace AppBanco
{
    abstract class User 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public BankAccount bankAccount { get; set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            this.bankAccount = new BankAccount(name);
        }
    }

}
