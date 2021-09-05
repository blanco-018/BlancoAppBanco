using System;
using System.Collections.Generic;
using System.Text;

namespace AppBanco.Interfaces
{
    interface IAccountable
    {
        public void AddBalance(decimal quantity);
        public void RemoveBalance(decimal quantity);
    }
}
