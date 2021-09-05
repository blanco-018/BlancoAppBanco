using System;
using System.Collections.Generic;
using System.Text;
using AppBanco.Classes;
using AppBanco.Interfaces;

namespace AppBanco.Services
{
    class EmployeeService
    {
        public void InterestRateCharge(Employee employee, User client)
        {
            decimal interestRate = 0.02m;
            decimal result = client.bankAccount.Balance * interestRate;
            client.bankAccount.RemoveBalance(result);
            Console.WriteLine($"{employee.Name} ha ingresado {result} a la cuenta con el nombre de {client.Name} por concepto de tipo de interés");
        }
    }
}
