using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public interface Iperson
    {
        List<Wallet> Wallets { get; set; }

        void CreateNewWallet(string walletName);
        void AddNewCardToWallet(string walletName, Card newCard);
        int FindWallet(string walletName);
        decimal GetInterestForAllWallets();

    }
}
