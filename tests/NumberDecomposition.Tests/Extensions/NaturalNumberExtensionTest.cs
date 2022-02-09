using NumberDecomposition.Extensions;
using Xunit;

namespace NumberDecomposition.Tests.Extensions
{
    public class NaturalNumberExtensionTest
    {
        [Theory]
        [InlineData(25, 20, false)]
        [InlineData(45, 15, true)]
        [InlineData(45, 45, true)]
        public void IsDivider(int value, int previousTerm, bool expected)
        {
            bool actual = value.IsDivider(previousTerm);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, false)]
        [InlineData(3, true)]
        [InlineData(100, false)]
        public void IsPrime(int value, bool expected)
        {
            bool actual = value.IsPrime();

            Assert.Equal(expected, actual);
        }
    }
}
