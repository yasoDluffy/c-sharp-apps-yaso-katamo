using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_yaso_katamo.BankApp
{
    public class Account
    {

        private Owner owner = null;

        private double balance = 0;

        private const int MAX_OVERDRAFT = 90_000;//positive

        private int overdraft = 0;//positive

        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.overdraft = overdraft;//positive value
        }

        //getters
        public Owner GetOwner()
        {
            return owner;
        }
        public double GetBalance() { return balance; }

        public int GetOverDraft() { return overdraft; }


        //max overdraft 90,000

        public void SetOverdraft(int overdraft)
        {
            if (overdraft > MAX_OVERDRAFT)
            {
                Console.WriteLine("You cannot do overdraft more than " + MAX_OVERDRAFT);
                return;
            }
            this.overdraft = overdraft;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (this.balance - amount < -overdraft)
            {
                Console.WriteLine("You cannot exceed the overdraft  ");
                return;
            }
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Owner = {owner.GetFirstName()} {owner.GetLastName()}\n" +
                $"balance = {balance}";
        }

    }
}
