using NUnit.Framework;
using System;
using ConsoleApp1.Models;

namespace ConsoleApp1Tests
{
    [TestFixture()]
    public class TestsCard
    {

        [Test()]
        public void NullCard()
        {
            Card card1 = new Card();

            Assert.IsNotNull(card1);
        }



        [TestCase(ConsoleApp1.CardType.Discover, 300, .01, ExpectedResult = 3)]
        [TestCase(ConsoleApp1.CardType.Discover, 200, .01, ExpectedResult = 2)]
        [TestCase(ConsoleApp1.CardType.Discover, 100, .01 , ExpectedResult = 1)]
        public decimal CardInterestRate_1(ConsoleApp1.CardType cardType, decimal balance, decimal interestRate)
        {
            Card card = new Card{ Type = cardType, Balance = balance, InterestRate = interestRate };

            return card.CalculatedCardInterest();

        }





    }
}
