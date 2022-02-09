using NumberDecomposition;
using NumberDecomposition.Interfaces;
using System;

namespace TechnicalChallangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = RequestNumber();
            IDecomposition decomposition = new NaturalNumber();
            decomposition.Decompose(number);
            Console.WriteLine($"Número de Entrada: {number}");
            Console.WriteLine($"Números Divisores: {string.Join(", ", decomposition.Dividers())}");
            Console.WriteLine($"Divisores Primos: {string.Join(", ", decomposition.Primes())}");
        }

        static int RequestNumber()
        {
            string number;
            int result;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite um número:");
                number = Console.ReadLine();
            } while (!int.TryParse(number, out result));

            return result;
        }
    }
}
