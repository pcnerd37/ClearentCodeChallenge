using System;

namespace ClearentCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test case
            Person person1 = new Person("Bob", 1);
            VisaCreditCard visaCreditCard = new VisaCreditCard(100);
            MastercardCreditCard mastercardCreditCard = new MastercardCreditCard(100);
            DiscoverCreditCard discoverCreditCard = new DiscoverCreditCard(100);
            person1.AddCardToWallet(1, discoverCreditCard);
            person1.AddCardToWallet(1, visaCreditCard);
            person1.AddCardToWallet(1, mastercardCreditCard);
            Console.WriteLine($"Person {person1.name} with total including interest {person1.CalculateTotalBalance()}");
            Console.WriteLine("Hello World!");

        }
    }
}
