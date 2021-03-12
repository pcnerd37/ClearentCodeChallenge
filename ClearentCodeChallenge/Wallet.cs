using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodeChallenge
{
    class Wallet
    {
        public List<ICreditCard> creditCards = new List<ICreditCard>();

        public Wallet()
        {
            // AddCard(creditCard);
        }

        public void AddCard(ICreditCard creditCard)
        {
            creditCards.Add(creditCard);
        }
    }
}
