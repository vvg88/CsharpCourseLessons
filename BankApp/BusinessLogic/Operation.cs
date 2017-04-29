using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    public abstract class Operation
    {
        public Account Account { get; private set; }

        public Employee Creator { get; private set; }

        public Operation(Account account, Employee creator)
        {
            Account = account;
            Creator = creator;
        }

        public abstract void Apply();
    }
}
