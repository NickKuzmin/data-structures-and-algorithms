using DataStructure.Algorithms.AlgorithmIsValidPalindrome;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmIsValidPalindrome_Tests
    {
        [InlineData("Lewd did I live & evil I did dwel", true)]
        [InlineData("assa", true)]
        [InlineData("text", false)]
        [Theory]
        public void AlgorithmIsValidPalindrome_CorrectInputValues_ExpectCorrectResult(string @string, bool expectedIsPalindrome)
        {
            var algorithmSwapVariablesWithoutTemporaryVariable = new AlgorithmIsValidPalindrome();

            var result = algorithmSwapVariablesWithoutTemporaryVariable.IsPalindrome(@string);

            Assert.Equal(expectedIsPalindrome, result);
        }

        [InlineData("Lewd did I live & evil I did dwel", true)]
        [InlineData("assa", true)]
        [InlineData("text", false)]
        [Theory]
        public void AlgorithmIsValidPalindrome_CorrectInputValues_ExpectCorrectResult2(string @string, bool expectedIsPalindrome)
        {
            var algorithmSwapVariablesWithoutTemporaryVariable = new AlgorithmIsValidPalindrome();

            var result = algorithmSwapVariablesWithoutTemporaryVariable.IsPalindrome(@string);

            Assert.Equal(expectedIsPalindrome, result);
        }
    }
}
