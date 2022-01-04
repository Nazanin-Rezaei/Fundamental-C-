using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_Operator_Overloading
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;

        }
        public double Money
        {
            get
            {
                return money;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }

        public static BankAccount operator + (BankAccount bank1, BankAccount bank2) 
            {
            double newAmountOfMoney = bank1.Money + bank2.Money;
            string newOwners = bank1.Owner + " + " + bank2.Owner;


            BankAccount newBankAccount = new BankAccount(newAmountOfMoney, newOwners);  
            return newBankAccount;
            }

        public static BankAccount operator + (BankAccount doesNotMatterName, double amounteee)
        {
            double newAmountOfMoney = doesNotMatterName.Money + amounteee;
            string newOwners = doesNotMatterName.Owner;

            BankAccount newBankAccount = new BankAccount( newAmountOfMoney, newOwners);
            return newBankAccount;

        }


    }
}
