using BankApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public abstract class MoneyOperation : Operation
    {
        public decimal DeltaMoney { get; private set; }

        public MoneyOperation(Account account, Employee creator, decimal moneyAmount)
            : base(account, creator)
        {
            DeltaMoney = moneyAmount;
        }
    }
}
