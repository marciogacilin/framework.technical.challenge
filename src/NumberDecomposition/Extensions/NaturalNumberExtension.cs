using System.Collections.Generic;

namespace NumberDecomposition.Extensions
{
    public static class NaturalNumberExtension
    {
        public static bool IsDivider(this int value, int element)
        {
            if (element == 0)
                return false;

            return value % element == 0;
        }

        public static bool IsPrime(this int value)
        {
            int totalDivisions = 0;
            int element = value;

            while (element > 0)
            {
                if (value % element == 0)
                    totalDivisions++;

                element--;
            }

            return totalDivisions == 2;
        }

        public static int[] AllowPrimes(this List<int> elements)
        {
            List<int> primes = new List<int>();
            foreach (var item in elements)
            {
                if (item.IsPrime())
                    primes.Add(item);
            }

            return primes.ToArray();
        }
    }
}
