using System;
namespace ConsoleApp1
{
    public class Main
    {
        public Main()
        {
            ConsoleApp1.Global.MasterCardInterest = .05m;
            ConsoleApp1.Global.VisaInterest = .10m;
            ConsoleApp1.Global.DiscoverInterest = .01m;
        }


        public void Exercise_One()
        {
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Exercise_One");
            Console.WriteLine("1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover) –");
            Console.WriteLine("Each Card has a balance of $100 –");
            Console.WriteLine("calculate the total interest (simple interest) for this person and per card. ");
            Console.WriteLine("");

            /*
             •	1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover) –
                Each Card has a balance of $100 –
                calculate the total interest (simple interest) for this person and per card. 
             */

            Models.Person newPerson = new Models.Person("Person 1");

            newPerson.CreateNewWallet("Personal");
            newPerson.AddNewCardToWallet("Personal", new Models.Card { Type = CardType.Visa, Balance = 100, Number = "123" });
            newPerson.AddNewCardToWallet("Personal", new Models.Card { Type = CardType.MasterCard, Balance = 100, Number = "456" });
            newPerson.AddNewCardToWallet("Personal", new Models.Card { Type = CardType.Discover, Balance = 100, Number = "789" });

            PrintResults(newPerson);

        }



        public void Exercise_Two()
        {
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Exercise_Two");
            Console.WriteLine("1 person has 2 wallets  Wallet 1 has a Visa and Discover ,");
            Console.WriteLine("wallet 2 a MC -  each card has $100 balance -");
            Console.WriteLine("calculate the total interest(simple interest) for this person and interest per wallet");
            Console.WriteLine("");

            /*
            •	1 person has 2 wallets  Wallet 1 has a Visa and Discover ,
                wallet 2 a MC -  each card has $100 balance -
                calculate the total interest(simple interest) for this person and interest per wallet
             */

            Models.Person newPerson = new Models.Person("Person 1");

            newPerson.CreateNewWallet("Business");
            newPerson.AddNewCardToWallet("Business", new Models.Card { Type = CardType.Visa, Balance = 100, Number = "123" });
            newPerson.AddNewCardToWallet("Business", new Models.Card { Type = CardType.Discover, Balance = 100, Number = "789" });


            newPerson.CreateNewWallet("Personal");
            newPerson.AddNewCardToWallet("Personal", new Models.Card { Type = CardType.MasterCard, Balance = 100, Number = "456" });

            PrintResults(newPerson);

        }

        public void Exercise_Three()
        {
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Exercise_Three");
            Console.WriteLine("2 people have 1 wallet each,");
            Console.WriteLine("person 1 has 1 wallet , with 2 cards MC and visa");
            Console.WriteLine("person 2 has 1 wallet – 1 visa and 1 MC -");
            Console.WriteLine("each card has $100 balance - calculate the total interest(simple interest) for each person and interest per wallet");
            Console.WriteLine("");

            /*
             *•	2 people have 1 wallet each,
             *      person 1 has 1 wallet , with 2 cards MC and visa
             *      person 2 has 1 wallet – 1 visa and 1 MC -
             *      each card has $100 balance - calculate the total interest(simple interest) for each person and interest per wallet
             */

            Models.Person person1 = new Models.Person("Person 1");
            Models.Person person2 = new Models.Person("Person 2");

            //person 1
            person1.CreateNewWallet("Business");
            person1.AddNewCardToWallet("Business", new Models.Card { Type = CardType.MasterCard, Balance = 100, Number = "123" });
            person1.AddNewCardToWallet("Business", new Models.Card { Type = CardType.Visa, Balance = 100, Number = "789" });

            //person 2
            person2.CreateNewWallet("Personal");
            person2.AddNewCardToWallet("Personal", new Models.Card { Type = CardType.MasterCard, Balance = 100, Number = "123" });
            person2.AddNewCardToWallet("Personal", new Models.Card { Type = CardType.Visa, Balance = 100, Number = "789" });

            PrintResults(person1);

            PrintResults(person2);

        }


        public void PrintResults(Models.Person newPerson)
        {
            Console.WriteLine("Person " + newPerson.Name);
            Console.WriteLine("Total interest for Person " + newPerson.GetInterestForAllWallets().ToString("0.00"));

            foreach (Models.Wallet wallet in newPerson.Wallets)
            {
                Console.WriteLine("Wallet " + wallet.WalletName);
                Console.WriteLine("Total interest for wallet " + wallet.GetInterestForAllCardsInWallet());

                foreach (Models.Card card in wallet.Cards)
                {
                    Console.WriteLine(card.Type.ToString() + " Card " + card.Number + " Interest " + card.CalculatedCardInterest().ToString("0.00"));

                }
            }
        }







    }
}
