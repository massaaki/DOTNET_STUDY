﻿namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}
