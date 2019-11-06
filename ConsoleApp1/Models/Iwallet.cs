using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public interface Iwallet
    {
        List<Card> Cards { get; set; }
        string WalletName { get; set; }
        void CreateCard(CardType cardType, string number);
        void CreateCard(Card newCard);
        decimal GetInterestForAllCardsInWallet();
    }
}
