using NumberDecomposition.Extensions;
using NumberDecomposition.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NumberDecomposition
{
    public class NaturalNumber : IDecomposition
    {
        private List<int> _decomposition = new List<int>();

        public void Decompose(int number)
        {
            int element = number;
            while (element > 0)
            {
                if (number.IsDivider(element))
                    _decomposition.Add(element);

                element--;
            }
        }

        public int[] Dividers() => _decomposition.OrderBy(i => i).ToArray();

        public int[] Primes() => _decomposition.OrderBy(i => i).ToList().AllowPrimes();
    }
}
