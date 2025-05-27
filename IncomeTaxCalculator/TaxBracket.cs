using System.Collections.Generic;

namespace IncomeTaxCalculator
{
    public class TaxBracket
    {
        public decimal LowerBound { get; set; }
        public decimal? UpperBound { get; set; }
        public decimal Rate { get; set; }
    }

    public static class TaxBrackets
    {
        public static readonly List<TaxBracket> Brackets = new List<TaxBracket>
        {
            new TaxBracket { LowerBound = 0, UpperBound = 10000, Rate = 0.10m },
            new TaxBracket { LowerBound = 10001, UpperBound = 50000, Rate = 0.20m },
            new TaxBracket { LowerBound = 50001, UpperBound = null, Rate = 0.30m }
        };
    }
}
