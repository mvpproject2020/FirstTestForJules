using System;
using System.Linq; // Although not strictly necessary for this implementation, it's good practice to include it if LINQ methods might be used in the future.

namespace IncomeTaxCalculator
{
    public static class TaxCalculator
    {
        public static decimal CalculateTax(decimal taxableIncome)
        {
            if (taxableIncome <= 0)
            {
                return 0;
            }

            decimal totalTax = 0;

            foreach (var bracket in TaxBrackets.Brackets.OrderBy(b => b.LowerBound)) // Ensure brackets are processed in order
            {
                if (taxableIncome > bracket.LowerBound)
                {
                    decimal incomeInBracket = Math.Min(taxableIncome, bracket.UpperBound ?? decimal.MaxValue);
                    decimal amountInBracket = incomeInBracket - bracket.LowerBound;

                    if (amountInBracket > 0)
                    {
                        decimal taxForBracket = amountInBracket * bracket.Rate;
                        totalTax += taxForBracket;
                    }

                    if (taxableIncome <= bracket.UpperBound && bracket.UpperBound != null)
                    {
                        break; 
                    }
                }
            }
            return totalTax;
        }
    }
}
