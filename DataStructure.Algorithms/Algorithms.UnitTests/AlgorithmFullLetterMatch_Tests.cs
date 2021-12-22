using DataStructure.Algorithms.AlgorithmFullLetterMatch;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmFullLetterMatch_Tests
    {
        [InlineData((string)null, (string)null, false)]
        [InlineData((string)"", (string)null, false)]
        [InlineData((string)"", "", false)]
        [InlineData((string)null, "", false)]
        [InlineData("dog", "dgo", false)]
        [InlineData("dog", "dfo", false)]
        [InlineData("doog", "ddog", false)]
        [Theory]
        public void AlgorithmAddTwoNumbers_CorrectInputValues_ExpectCorrectResult(string firstString, string secondString, bool expectedResult)
        {
            var algorithmFullLetterMatch = new AlgorithmFullLetterMatch();
            var actualResult = algorithmFullLetterMatch.IsMatch(firstString, secondString);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
