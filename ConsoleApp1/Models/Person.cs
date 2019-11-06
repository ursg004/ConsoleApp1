using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Models
{
    public class Person : Iperson
    {


        public List<Wallet> Wallets { get; set; }
        public String Name { get; set; }

        public Person()
        {
            Wallets = new List<Wallet>();
        }

        public Person(string name)
        {
            Wallets = new List<Wallet>();
            this.Name = name;
        }


        public void CreateNewWallet(string walletName)
        {

            this.Wallets.Add(new Wallet { WalletName = walletName });
        }



        public void AddNewCardToWallet(string walletName, Card newCard)
        {
            this.Wallets[FindWallet(walletName)].CreateCard(newCard);
        }



        public int FindWallet(string walletName)
        {
            int index = -1;

            try
            {
                index = Wallets.FindIndex(c => c.WalletName == walletName);

            }
            catch (Exception ex)
            {
                // add logging with ex.message
                throw;
            }

            return index;
        }


        public decimal GetInterestForAllWallets()
        {

            decimal total = 0;

            IEnumerator<Wallet> ienum;

            ienum = this.Wallets.GetEnumerator();

            while (ienum.MoveNext())
            {
                decimal temp = ienum.Current.GetInterestForAllCardsInWallet();

                total = total + temp;

            }

            return total;

        }





    }
}
