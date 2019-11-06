using System;
using ConsoleApp1.Models;
using NUnit.Framework;

namespace ConsoleApp1Tests
{
    public class TestOverall
    {

        [SetUp]
        public void Setup()
        {
            ConsoleApp1.Global.MasterCardInterest = .05m;
            ConsoleApp1.Global.VisaInterest = .10m;
            ConsoleApp1.Global.DiscoverInterest = .01m;
        }

        // note i could have pull all the test cases to call one test method but
        // i like to to see the different tests broken out on the test console


         // 5%
        [TestCase(ConsoleApp1.CardType.MasterCard, 399, ExpectedResult = 19.95)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 375, ExpectedResult = 18.75)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 360, ExpectedResult = 18)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 350, ExpectedResult = 17.5)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 340, ExpectedResult = 17)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 330, ExpectedResult = 16.5)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 310, ExpectedResult = 15.5)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 300, ExpectedResult = 15)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 200, ExpectedResult = 10)]
        [TestCase(ConsoleApp1.CardType.MasterCard, 100, ExpectedResult = 5)]
        public decimal Test_MasterCard(ConsoleApp1.CardType cardType, decimal balance)
        {

            Person newPerson = new Person();

            newPerson.CreateNewWallet("Business");

            newPerson.AddNewCardToWallet("Business", new Card { Type = cardType, Balance = balance});

            return newPerson.GetInterestForAllWallets();

        }


        // 10%
        [TestCase(ConsoleApp1.CardType.Visa, 399, ExpectedResult = 39.9)]
        [TestCase(ConsoleApp1.CardType.Visa, 375, ExpectedResult = 37.5)]
        [TestCase(ConsoleApp1.CardType.Visa, 360, ExpectedResult = 36)]
        [TestCase(ConsoleApp1.CardType.Visa, 350, ExpectedResult = 35)]
        [TestCase(ConsoleApp1.CardType.Visa, 340, ExpectedResult = 34)]
        [TestCase(ConsoleApp1.CardType.Visa, 330, ExpectedResult = 33)]
        [TestCase(ConsoleApp1.CardType.Visa, 310, ExpectedResult = 31)]
        [TestCase(ConsoleApp1.CardType.Visa, 300, ExpectedResult = 30)]
        [TestCase(ConsoleApp1.CardType.Visa, 200, ExpectedResult = 20)]
        [TestCase(ConsoleApp1.CardType.Visa, 100, ExpectedResult = 10)]
        public decimal Test_VisaCard(ConsoleApp1.CardType cardType, decimal balance)
        {

            Person newPerson = new Person();

            newPerson.CreateNewWallet("Business");

            newPerson.AddNewCardToWallet("Business", new Card { Type = cardType, Balance = balance });

            return newPerson.GetInterestForAllWallets();

        }


        // 1%
        [TestCase(ConsoleApp1.CardType.Discover, 399, ExpectedResult = 3.99)]
        [TestCase(ConsoleApp1.CardType.Discover, 375, ExpectedResult = 3.75)]
        [TestCase(ConsoleApp1.CardType.Discover, 360, ExpectedResult = 3.6)]
        [TestCase(ConsoleApp1.CardType.Discover, 350, ExpectedResult = 3.5)]
        [TestCase(ConsoleApp1.CardType.Discover, 340, ExpectedResult = 3.4)]
        [TestCase(ConsoleApp1.CardType.Discover, 330, ExpectedResult = 3.3)]
        [TestCase(ConsoleApp1.CardType.Discover, 310, ExpectedResult = 3.1)]
        [TestCase(ConsoleApp1.CardType.Discover, 300, ExpectedResult = 3)]
        [TestCase(ConsoleApp1.CardType.Discover, 200, ExpectedResult = 2)]
        [TestCase(ConsoleApp1.CardType.Discover, 100, ExpectedResult = 1)]
        public decimal Test_DiscoverCard(ConsoleApp1.CardType cardType, decimal balance)
        {

            Person newPerson = new Person();

            newPerson.CreateNewWallet("Business");

            newPerson.AddNewCardToWallet("Business", new Card { Type = cardType, Balance = balance });

            return newPerson.GetInterestForAllWallets();

        }



    }
}
