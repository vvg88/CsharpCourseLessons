using BankApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class OpenOperation : Operation
    {
        public OpenOperation(Account account, Employee creator)
            : base(account, creator)
        {
        }

        public override void Apply()
        {
            Account.Open();
        }
    }
}
