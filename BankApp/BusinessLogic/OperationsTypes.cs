using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    [Flags]
    public enum OperationsTypes : long
    {
        None,
        OpenAccount = 1,
        CloseAccount,
        PullMoney = 4,
        PushMoney = 8
    }
}
