using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_Operator_Overloading
{
   internal class Operator_Overloading
    {
        class BankAccount
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
        }
    }
}
