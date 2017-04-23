using BankApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    public class Bank
    {
        public List<Employee> Employees { get; }

        public List<Client> Clients { get; }

        public List<Account> Accounts { get; }

        public Employee CreateEmployee(string name, string passWrd, OperationsTypes allowedOp)
        {
            var newEmpl = new Employee(Employees.Count, name, passWrd, allowedOp);
            Employees.Add(newEmpl);
            return newEmpl;
        }

        public bool LoginEmployee(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmploeeByOperation(OperationsTypes opType)
        {
            throw new NotImplementedException();
        }

        public Bank()
        {
            Employees = new List<Employee>();
            Clients = new List<Client>();
            Accounts = new List<Account>();
        }
    }
}
