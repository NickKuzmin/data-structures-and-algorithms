using DataStructure.Algorithms.AddTwoNumbers;
using Xunit;

namespace Algorithms.UnitTests
{
    public class AlgorithmAddTwoNumbers_Tests
    {
        [InlineData((object)new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8})]
        [InlineData((object)new[] { 0 }, new[] { 0 }, new[] { 0 })]
        [InlineData((object)new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        [Theory]
        public void AlgorithmAddTwoNumbers_CorrectInputValues_ExpectCorrectResult(int[] listNodeValues1, int[] listNodeValues2, int[] expectedResultValues)
        {
            var node1 = new AlgorithmAddTwoNumbers.ListNode();
            var currentNode1 = node1;
            foreach (var listNodeValue in listNodeValues1)
            {
                currentNode1.Value = listNodeValue;
                var newNode = new AlgorithmAddTwoNumbers.ListNode();
                currentNode1.Next = newNode;
                currentNode1 = newNode;
            }

            var node2 = new AlgorithmAddTwoNumbers.ListNode();
            var currentNode2 = node2;
            foreach (var listNodeValue in listNodeValues2)
            {
                currentNode2.Value = listNodeValue;
                var newNode = new AlgorithmAddTwoNumbers.ListNode();
                currentNode2.Next = newNode;
                currentNode2 = newNode;
            }

            var algorithmAddTwoNumbers = new AlgorithmAddTwoNumbers();
            var result = algorithmAddTwoNumbers.Execute(node1, node2);

            Assert.NotNull(result);
            var currentResultNode = result;
            foreach (var expectedResult in expectedResultValues)
            {
                Assert.Equal(expectedResult, currentResultNode.Value);
                currentResultNode = currentResultNode.Next;
            }
        }
    }
}
