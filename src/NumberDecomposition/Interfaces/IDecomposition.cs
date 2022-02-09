namespace NumberDecomposition.Interfaces
{
    public interface IDecomposition
    {
        void Decompose(int number);
        int[] Primes();
        int[] Dividers();
    }
}
