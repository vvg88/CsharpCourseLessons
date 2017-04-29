using BankApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class PullOperation : MoneyOperation
    {
        public PullOperation(Account account, Employee creator, decimal moneyAmount)
            : base(account, creator, moneyAmount)
        {
        }

        public override void Apply()
        {
            Account.DecreaseMoney(DeltaMoney);
        }
    }
}
