using System;
using ConsoleApp1.Models;
using NUnit.Framework;

namespace ConsoleApp1Tests
{
    public class TestsPerson
    {


        [Test()]
        public void TestPerson_1()
        {
            Person person1 = new Person();

            person1.CreateNewWallet("Business");

            person1.Wallets[0].CreateCard(ConsoleApp1.CardType.Discover, "123456");

            Assert.IsTrue(person1.Wallets.Count == 1);
        }
    }
}
