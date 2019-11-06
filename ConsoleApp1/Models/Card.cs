using System;
namespace ConsoleApp1.Models
{
    public class Card : Icard
    {
        private decimal _InterestRate = 0;

        public string Number { get; set; }

        public CardType Type { get; set; }

        public decimal Balance { get; set; }

        //public decimal InterestRate { get; set; }

        public decimal InterestRate { get => Global.GetInterestForCardType(this.Type); set => _InterestRate = value; }


        public decimal CalculatedCardInterest()
        {
            decimal returnInterest = 0;

            try
            {
                returnInterest = Balance * InterestRate;
            }
            catch
            {
                throw;
            }

            return returnInterest;
        }


    }
}
