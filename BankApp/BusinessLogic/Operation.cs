using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    public class Operation
    {
        public Account Account { get; private set; }

        public OperationsTypes OperationType { get; private set; }

        public Employee Creator { get; private set; }

        public decimal DeltaMoney { get; private set; }

        public Operation(Account account, OperationsTypes opType, Employee creator, decimal moneyAmount)
        {
            Account = account;
            OperationType = opType;
            Creator = creator;
            DeltaMoney = moneyAmount;
        }

        public void Apply()
        {
            switch(OperationType)
            {
                case OperationsTypes.CloseAccount:
                    Account.Close();
                    break;
                case OperationsTypes.OpenAccount:
                    Account.Open();
                    break;
                case OperationsTypes.PullMoney:
                    Account.PullMoney(DeltaMoney);
                    break;
                case OperationsTypes.PushMoney:
                    Account.PushMoney(DeltaMoney);
                    break;
            }
        }
    }
}
