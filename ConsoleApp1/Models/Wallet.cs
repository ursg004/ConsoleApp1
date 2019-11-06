using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Wallet
    {
        public List<Card> Cards { get; set; }

        public string WalletName { get; set; }


        public Wallet()
        {
            Cards = new List<Card>();
        }

        public void CreateCard(CardType cardType, string number)
        {
            if (this.Cards is null)
            {
                this.Cards = new List<Card>();

            }

            this.Cards.Add(new Card {  Type = cardType , Number = number });

        }


        public void CreateCard(Card newCard)
        {

            this.Cards.Add(new Card { Type = newCard.Type, Number = newCard.Number, Balance = newCard.Balance, InterestRate = newCard.InterestRate});

        }

        public decimal GetInterestForAllCardsInWallet()
        {

            decimal total = 0;

            IEnumerator<Card> ienum;

            ienum = this.Cards.GetEnumerator();

            while(ienum.MoveNext())
            {
                decimal temp = ienum.Current.CalculatedCardInterest();

                total = total + temp;

            }

            return total;
        }




    }
}
