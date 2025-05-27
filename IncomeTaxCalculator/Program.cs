using System;
using System.Globalization; // Required for CultureInfo

namespace IncomeTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Income Tax Calculator");
            Console.Write("Please enter your taxable income: ");
            string? input = Console.ReadLine();

            if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal taxableIncome))
            {
                if (taxableIncome < 0)
                {
                    Console.WriteLine("Taxable income cannot be negative. Please enter a non-negative value.");
                }
                else
                {
                    decimal taxAmount = TaxCalculator.CalculateTax(taxableIncome);
                    // Format as currency, e.g., $X,XXX.XX. Using "C" with InvariantCulture or specific CultureInfo.
                    Console.WriteLine($"Your calculated income tax is: {taxAmount:C}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number for taxable income.");
            }
        }
    }
}
