using DataStructure.Algorithms.AlgorithmFindMedianSortedArrays;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmFindMedianSortedArrays_Tests
    {
        [InlineData((object)new[] { 1, 2 }, new[] { 2 }, (double)2)]
        [InlineData((object)new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        [InlineData((object)new[] { 0, 0 }, new[] { 0, 0 }, (double)0)]
        [InlineData((object)new int[] { }, new[] { 1 }, (double)1)]
        [InlineData((object)new[] { 2 }, new int[] { }, (double)2)]
        [Theory]
        public void AlgorithmFindMedianSortedArrays_CorrectInputValues_ExpectCorrectResult(int[] array1, int[] array2, double expectedResult)
        {
            var algorithmFindMedianSortedArrays = new AlgorithmFindMedianSortedArrays();

            var result = algorithmFindMedianSortedArrays.Execute(array1, array2);

            Assert.Equal(expectedResult, result);
        }
    }
}
