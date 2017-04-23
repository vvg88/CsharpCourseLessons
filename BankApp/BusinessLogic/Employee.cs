using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    public class Employee
    {
        public bool IsSignedIn { get; private set; }

        public int Number { get; private set; }

        public string Name { get; private set; }

        public string Password { get; private set; }

        public List<OperationsTypes> AllowedOperatinType { get; } = new List<OperationsTypes>();

        public Employee(int number, string name, string passwrd, OperationsTypes allowedOpTypes)
        {
            Number = number;
            Password = passwrd;
            Name = name;
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
