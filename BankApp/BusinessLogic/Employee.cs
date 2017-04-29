using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    public class Employee : Person
    {
        public bool IsSignedIn { get; private set; }

        public string Password { get; private set; }

        public OperationsTypes AllowedOperatinType { get; }

        public Employee(int number, string name, string passwrd, OperationsTypes allowedOpTypes)
            : base(number, name)
        {
            Password = passwrd;
            AllowedOperatinType = allowedOpTypes;
        }

        public void SignIn()
        {
            IsSignedIn = true;
        }

        public void SignOut()
        {
            IsSignedIn = false;
        }

        public void CreateOperation(OperationsTypes opType, decimal moneyAmount)
        {
            // Проверить доступ сотрудника
            // Создать операцию
            // Применить операцию
        }
    }
}
