using DataStructure.Algorithms.FindArrayIndexesForSum;
using System;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmFindArrayIndexForSum_Tests
    {
        [InlineData((object)new[] { 35, 12, 4, 15, 68, 2, 3, 10 }, 5, true, new[] { 5, 6 })]
        [InlineData((object)new[] { 110, 23, 22, 1, 0, 14, 55, 35 }, 49, true, new[] { 5, 7 })]
        [InlineData((object)new[] { 110, 23, 22, 1, 0, 14, 55, 35 }, 36, true, new[] { 3, 7 })]
        [InlineData((object)new[] { 110, 23, 22, 1, 0, 14, 55, 35 }, 145, true, new[] { 0, 7 })]
        [InlineData((object)new[] { 110, 23, 22, 1, 0, 14, 55, 35 }, 133, true, new[] { 0, 1 })]
        [Theory]
        public void AlgorithmFindArrayIndexForSum_UnsortedArray_ExpectCorrectResult(int[] array, int searchValue, bool expectedFoundResult, int[] expectedIndices)
        {
            var algorithmFindArrayIndexForSum = new AlgorithmFindArrayIndexForSum();
            var result = algorithmFindArrayIndexForSum.FindArrayIndexForSum(array, searchValue);

            Assert.NotNull(result);
            Assert.True(result.IsFound == expectedFoundResult);
            if (expectedFoundResult)
            {
                Assert.NotNull(result.FirstIndex);
                Assert.Contains(result.FirstIndex.Value, expectedIndices);
                Assert.NotNull(result.SecondIndex);
                Assert.Contains(result.SecondIndex.Value, expectedIndices);
            }
        }

        [InlineData((object)new[] { 2, 3, 4, 10, 12, 15, 35, 68 }, 5, true, new[] { 0, 1 })]
        [InlineData((object)new[] { 2, 3, 4, 10, 12, 15, 35, 68 }, 11, false, new int[] { })]
        [InlineData((object)new[] { 68, 35, 15, 12, 10, 4, 3, 2 }, 5, true, new[] { 6, 7 })]
        [InlineData((object)new[] { 68, 35, 15, 12, 10, 4, 3, 2 }, 27, true, new[] { 2, 3 })]
        [InlineData((object)new[] { 68, 35, 15, 12, 10, 4, 3, 2 }, 9, false, new int[] { })]
        [InlineData((object)new[] { 2, 3, 4, 10, 12, 15, 35, 68 }, 27, true, new[] { 4, 5 })]
        [InlineData((object)new[] { 2, 3, 4, 10, 12, 15, 35, 68 }, 8, false, new int[] { })]
        [Theory]
        public void AlgorithmFindArrayIndexForSum_SortedArray_ExpectCorrectResult(int[] array, int searchValue, bool expectedFoundResult, int[] expectedIndices)
        {
            var algorithmFindArrayIndexForSum = new AlgorithmFindArrayIndexForSum();
            var result = algorithmFindArrayIndexForSum.FindArrayIndexForSum(array, searchValue);

            Assert.True(result.IsFound == expectedFoundResult);
            if (expectedFoundResult)
            {
                Assert.NotNull(result.FirstIndex);
                Assert.Contains(result.FirstIndex.Value, expectedIndices);
                Assert.NotNull(result.SecondIndex);
                Assert.Contains(result.SecondIndex.Value, expectedIndices);
            }
        }


    }
}
