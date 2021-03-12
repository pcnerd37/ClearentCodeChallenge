using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodeChallenge
{
    class DiscoverCreditCard : ICreditCard
    {
        public double InterestRate { get; set; }
        public double Balance { get; set; }

        //Constructor
        public DiscoverCreditCard(double balance)
        {
            InterestRate = .01;
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
