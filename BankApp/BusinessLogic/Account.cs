using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BusinessLogic
{
    public class Account
    {
        public decimal Balance { get; private set; } = 0;

        public bool IsOpen { get; private set; }

        public Client OwnerClient { get; private set; }

        public int Number { get; private set; }

        public DateTime CreationDate { get; private set; }

        public void Open()
        {
            IsOpen = true;
        }

        public void Close()
        {
            IsOpen = false;
        }

        public Account(Client ownerClient, int number)
        {
            OwnerClient = ownerClient;
            Number = number;
            CreationDate = DateTime.Now;
            Open();
        }

        public void DecreaseMoney(decimal value)
        {
            if (Balance < value)
                throw new Exception("Недостаточно средств на счете!");
            Balance -= value;
        }

        public void IncreaseMoney(decimal money)
        {
            Balance += money;
        }
    }
}
