using DataStructure.Algorithms.AlgorithmSwapVariablesWithoutTemporaryVariable;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmIsPrime_Tests
    {
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(9, false)]
        [Theory]
        public void AlgorithmIsPrime_CorrectInputValues_ExpectCorrectResult(int number, bool isPrime)
        {
            var algorithmIsPrime = new AlgorithmIsPrime();

            var result = algorithmIsPrime.IsPrime(number);

            Assert.Equal(isPrime, result);
        }
    }
}
