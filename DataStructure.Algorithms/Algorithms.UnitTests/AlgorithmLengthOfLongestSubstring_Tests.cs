using DataStructure.Algorithms.LengthOfLongestSubstring;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmLengthOfLongestSubstring_Tests
    {
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [Theory]
        public void AlgorithmLengthOfLongestSubstring_CorrectInputValues_ExpectCorrectResult(string @string, int maxLenghtSubstring)
        {
            var algorithmLengthOfLongestSubstring = new AlgorithmLengthOfLongestSubstring();

            var result = algorithmLengthOfLongestSubstring.Execute(@string);

            Assert.Equal(maxLenghtSubstring, result);
        }
    }
}
