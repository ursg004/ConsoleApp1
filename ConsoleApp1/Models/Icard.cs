using System;
namespace ConsoleApp1.Models
{
    public interface Icard
    {
        string Number { get; set; }
        CardType Type { get; set; }
        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        decimal CalculatedCardInterest();
    }
}
