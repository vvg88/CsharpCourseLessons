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

        public Employee CurrentEmployee { get; private set; }

        public List<Operation> OperationsHistory { get; private set; }

        public Bank()
        {
            Employees = new List<Employee>();
            Clients = new List<Client>();
            Accounts = new List<Account>();
            OperationsHistory = new List<Operation>();
        }

        public Employee CreateEmployee(string name, string passWrd, OperationsTypes allowedOp)
        {
            var newEmpl = new Employee(Employees.Count, name, passWrd, allowedOp);
            Employees.Add(newEmpl);
            return newEmpl;
        }

        public bool LoginEmployee(string name, string password)
        {
            if (Employees == null)
                return false;
            
            Employee targetEmployee = Employees.FirstOrDefault(employee => employee.Name == name && employee.Password == password);
            CurrentEmployee = targetEmployee;
            return targetEmployee != null;
        }
        
        public Client CreateClient(string name)
        {
            var clnt = new Client(Clients.Count, name);
            Clients.Add(clnt);
            return clnt;
        }

        public Account CreateAccount(Client clnt)
        {
            var accnt = new Account(clnt, Accounts.Count + 1);
            Accounts.Add(accnt);
            return accnt;
        }

        public void PushMoney(Account accnt, decimal deltaMoney)
        {
            CheckAccess(OperationsTypes.PushMoney);
            var pushOp = new PushOperation(accnt, CurrentEmployee, deltaMoney);
            pushOp.Apply();
            OperationsHistory.Add(pushOp);
        }

        public void PullMoney(Account accnt, decimal deltaMoney)
        {
            CheckAccess(OperationsTypes.PullMoney);
            var pullOp = new PullOperation(accnt, CurrentEmployee, deltaMoney);
            pullOp.Apply();
            OperationsHistory.Add(pullOp);
        }

        public void AddAccount(Client ownerClient)
        {
            if (ownerClient == null)
                return;
            CheckAccess(OperationsTypes.OpenAccount);
            CreateAccount(ownerClient);
        }

        public void RemoveAccount(Account selAccount)
        {
            CheckAccess(OperationsTypes.CloseAccount);
            Accounts.Remove(selAccount);
        }

        private void CheckAccess(OperationsTypes op)
        {
            if (!CurrentEmployee.AllowedOperatinType.HasFlag(op))
            {
                throw new Exception("Нет прав доступа!");
            }
        }
    }
}
