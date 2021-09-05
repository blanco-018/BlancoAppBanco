using System;
using AppBanco.Classes;
using AppBanco.Services;
using static AppBanco.Classes.Constants;

namespace AppBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            UserService userService = new UserService();
            BankAccountService bankAccountService = new BankAccountService();
            EmployeeService employeeService = new EmployeeService();

            var javi = userService.Register("Javier", "javier2342@gmail.com", Usertype.client);

            var julia = userService.Register("Julia", "julia7987@hotmail.com", Usertype.client);

            var e_jerry = (Employee)userService.Register("Chema", "chema@banco.com", Usertype.employee);

            javi.bankAccount.AddBalance(5500);

            bankAccountService.Transaction(javi, julia, 1260);

            userService.CreateAccount(e_jerry);

            
            employeeService.InterestRateCharge(e_jerry, javi);
            employeeService.InterestRateCharge(e_jerry, julia);

            Console.WriteLine("hola");
        }
    }
}
