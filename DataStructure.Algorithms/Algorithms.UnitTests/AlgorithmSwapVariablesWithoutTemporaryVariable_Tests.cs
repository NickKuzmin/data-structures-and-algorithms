using DataStructure.Algorithms.AlgorithmSwapVariablesWithoutTemporaryVariable;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmSwapVariablesWithoutTemporaryVariable_Tests
    {
        [InlineData(3, 5)]
        [InlineData(5, 3)]
        [InlineData(5, 5)]
        [InlineData(15, 5)]
        [InlineData(5, 15)]
        [InlineData(6, 3)]
        [InlineData(3, 6)]
        [Theory]
        public void AlgorithmSwapVariablesWithoutTemporaryVariable_CorrectInputValues_ExpectCorrectResult(int a, int b)
        {
            var expectedA = b;
            var expectedB = a;
            var algorithmSwapVariablesWithoutTemporaryVariable = new AlgorithmSwapVariablesWithoutTemporaryVariable();

            algorithmSwapVariablesWithoutTemporaryVariable.Execute(ref a, ref b);

            Assert.Equal(expectedA, a);
            Assert.Equal(expectedB, b);
        }
    }
}
