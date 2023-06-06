using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture61exer2
{
    public class Taxpayer
    {
        public string socialSecurity{get; set;}

        public double yearlyIncome{get; set;}

        public double taxesOwed{get; set;}



        public Taxpayer(string ssNum, double Yearly)
        {
            this.socialSecurity = ssNum;
            yearlyIncome = Yearly;
        }

        private void Taxes()
        {
            if(yearlyIncome > 30000)
            {
                taxesOwed = yearlyIncome * .28;
            }
            else
            {
                taxesOwed = yearlyIncome * .15;
            }
        }
    }
}