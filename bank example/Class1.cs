using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_example
{
    public class BankAccount
    {
       protected decimal balance;
       protected decimal annualRate=0.05m;
       public decimal Balance { get { return balance; } }
        public decimal AnnualRate
        {
            get
            {
                return annualRate;
            }
            set
            {
                if (value < 0)
                {
                    annualRate = 0.05m;
                }
                else
                {
                    annualRate = value;
                }
            }
        }

        public BankAccount(decimal balance, decimal annualRate)
        {
            this.balance = balance<0?0:balance;
            this.annualRate = annualRate<0?0.05m:annualRate;
        }

        public bool Deposit (decimal amount)
        {
            bool result = true;
            if (amount < 0)
            {
                return result = false;
            }
            balance += amount;
            return result;
        }

        public virtual bool WithDraw (decimal amount)
        {
            bool result = true;
            if (amount<0||amount>balance)
            {
                return result = false;
            }
            balance -= amount;
            return result;
        }

        public void AddMonthlyInterest()
        {
            decimal monthlyInterest = annualRate / 12;
            balance += balance * monthlyInterest;
        }

        public override string ToString()
        {
            return balance.ToString();
        }
    }

    public class CheckingAccount : BankAccount
    {
        private decimal overDraftLimit;

        public decimal OverDraftLimit
        {
            get
            {
                return overDraftLimit;
            }

            set
            {
                overDraftLimit=(overDraftLimit <= 0 ? 500m : value);
            }
        }
        public CheckingAccount(decimal balance, decimal annualRate,decimal overDraftLimit) : base(balance, annualRate)
        {
            this.overDraftLimit = (overDraftLimit <= 0 ? 500m : overDraftLimit);
        }

        public override bool WithDraw (decimal amount)
        {
            bool result = true;
            if (amount < 0 || amount > balance+overDraftLimit)
            {
                return result = false;
            }
            balance -= amount;
            return result;
        }

        public override string ToString()
        {
            return balance.ToString();
        }
    }
}
