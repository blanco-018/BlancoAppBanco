using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;
using static AppBanco.Classes.Constants;

namespace AppBanco.Interfaces
{
    interface IRegisterable
    {
        public User Register(string name, string email, UserType usertype);
        public bool Validate(string email);
    }
}
