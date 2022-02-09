namespace NumberDecomposition.Interfaces
{
    public interface IDecompositionService
    {
        void Decompose(int number);
        int[] Primes();
        int[] Dividers();
    }
}
