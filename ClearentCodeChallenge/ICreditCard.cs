using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodeChallenge
{
    interface ICreditCard
    {
        double InterestRate
        {
            get;
            set;
        }

        double Balance
        {
            get;
            set;
        }

        double CalculateInterest();

    }
}
