using DataStructure.Algorithms.ReverseWordsBySpace;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmReverseWordsBySpace_Tests
    {
        [InlineData("Geeks for Geeks", "skeeG rof skeeG")]
        [Theory]
        public void AlgorithmReverseWordsBySpace_CorrectInputValues_ExpectCorrectResult(string @string, string expectedString)
        {
            var algorithmReverseWordsBySpace = new AlgorithmReverseWordsBySpace();

            var result = algorithmReverseWordsBySpace.Execute(@string);

            Assert.Equal(expectedString, result);
        }
    }
}
