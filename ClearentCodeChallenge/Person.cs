using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodeChallenge
{
    class Person
    {
        public string name;
        public Wallet[] wallets;
        public double totalBalance;

        //Constructor
        public Person(string name, int numberOfWallets)
        {
            this.name = name;
            wallets = new Wallet[numberOfWallets];
            
            for (int i = 1; i <= numberOfWallets; i++)
            {
                wallets[i - 1] = new Wallet();
            }
        }

        public void AddCardToWallet(int walletNumber, ICreditCard creditCard)  
        {
            wallets[walletNumber - 1].AddCard(creditCard);
        }

        public double CalculateTotalBalance ()
        {
            foreach(Wallet w in wallets)
            {
                foreach(ICreditCard creditCard in w.creditCards)
                {
                    totalBalance += creditCard.Balance;
                }
            }
            return totalBalance;
        }
    }
}
