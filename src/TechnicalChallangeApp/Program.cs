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
            IDecompositionService decompositionService = new NaturalNumberService();
            decompositionService.Decompose(number);
            Console.WriteLine($"Número de Entrada: {number}");
            Console.WriteLine($"Números Divisores: {string.Join(", ", decompositionService.Dividers())}");
            Console.WriteLine($"Divisores Primos: {string.Join(", ", decompositionService.Primes())}");
            Console.ReadKey();
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
