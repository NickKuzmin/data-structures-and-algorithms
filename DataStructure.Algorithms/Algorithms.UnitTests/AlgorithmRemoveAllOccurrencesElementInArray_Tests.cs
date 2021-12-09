using System.Linq;
using DataStructure.Algorithms.AlgorithmRemoveAllOccurrencesElementInArray;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmRemoveAllOccurrencesElementInArray_Tests
    {
        [InlineData(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 }, 2)]
        [InlineData(new[] { 3, 2, 2, 3 }, 2, new[] { 3, 3 }, 2)]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 3, 0, 4 }, 5)]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 0, new[] { 1, 2, 2, 3, 4, 2 }, 6)]
        [Theory]
        public void AlgorithmReverseWordsBySpace_CorrectInputValues_ExpectCorrectResult(int[] array, int removingElement,
            int[] expectedArray, int expectedCountNotRemovedElements)
        {
            var algorithmRemoveAllOccurrencesElementInArray = new AlgorithmRemoveAllOccurrencesElementInArray();

            var countNotRemovedElements = algorithmRemoveAllOccurrencesElementInArray.Execute(array, removingElement);

            Assert.Equal(expectedCountNotRemovedElements, countNotRemovedElements);
            array = array.Take(expectedCountNotRemovedElements).ToArray();
            for (var i = 0; i < array.Length; i++)
            {
                Assert.Equal(expectedArray[i], array[i]);
            }
        }
    }
}
