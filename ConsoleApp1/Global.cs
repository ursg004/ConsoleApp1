using System;
namespace ConsoleApp1
{
    public static class Global
    {
        public static decimal VisaInterest { get; set; }
        public static decimal MasterCardInterest { get; set; }
        public static decimal DiscoverInterest { get; set; }


        
        public static decimal GetInterestForCardType( CardType cardtype)
        {
            decimal returnValue = 0;

            switch (cardtype)
            {
                case CardType.Visa:
                    returnValue = VisaInterest;
                    break;

                case CardType.MasterCard:
                    returnValue = MasterCardInterest;
                    break;

                case CardType.Discover:
                    returnValue = DiscoverInterest;
                    break;

                default:
                    throw new ApplicationException("Card type does not exist");
                    //break;
            }


            return returnValue;

        }

    



    }
}
