using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_2_Class
{
    internal class Taxpayer
    {
        private string socialSequrityNumber;
        private double yearlyGrossIncome;
        private double owedTax;

       
        public string SocialSequrityNumber
        {
            get
            {
                return socialSequrityNumber;
            }
            set
            {
                socialSequrityNumber = value;
            }
        }
        public double YearlyGrossIncome
        {

            get
            {
                return yearlyGrossIncome;
            }

            set
            {
                yearlyGrossIncome = value;
                calOwedTax();
            }
            
        }
        public double OwedTax
        {
            get
            {
                return owedTax;
            }
        }
        private void calOwedTax()
        {
            if (yearlyGrossIncome < 30000)
            {
                owedTax = yearlyGrossIncome * 0.15;
            }
            else
            {
                owedTax = yearlyGrossIncome * 0.28;
            }
        }

    }


}


