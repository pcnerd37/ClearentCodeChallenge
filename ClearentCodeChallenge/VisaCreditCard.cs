using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodeChallenge
{
    class VisaCreditCard : ICreditCard
    {
        public double InterestRate { get; set; }
        public double Balance { get; set; }

        //Constructor
        public VisaCreditCard(double balance)
        {
            InterestRate = .1;
            Balance = balance;
            CalculateInterest();
        }

        public double CalculateInterest()
        {
            double interest = Balance * InterestRate;
            return Balance = Balance + interest;
        }
    }
}
