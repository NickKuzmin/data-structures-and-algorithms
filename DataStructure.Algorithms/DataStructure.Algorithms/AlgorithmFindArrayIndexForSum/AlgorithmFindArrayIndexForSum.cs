using System.Collections.Generic;

namespace DataStructure.Algorithms.AlgorithmFindArrayIndexForSum
{
    public class AlgorithmFindArrayIndexForSum
    {
        public AlgorithmFindArrayIndexForSumResult FindArrayIndexForSum(int[] array, int searchValue)
        {
            var dictionaryIndexByValue = new Dictionary<int, int>();
            for (var index = 0; index < array.Length; index++)
            {
                var currentElement = array[index];
                var rest = searchValue - currentElement;

                if (dictionaryIndexByValue.ContainsKey(rest))
                {
                    return new AlgorithmFindArrayIndexForSumResult
                    {
                        IsFound = true,
                        FirstIndex = index,
                        SecondIndex = dictionaryIndexByValue[rest]
                    };
                }

                dictionaryIndexByValue[currentElement] = index;
            }

            return new AlgorithmFindArrayIndexForSumResult
            {
                IsFound = false
            };
        }

        public class AlgorithmFindArrayIndexForSumResult
        {
            public bool IsFound { get; set; }

            public int? FirstIndex { get; set; }

            public int? SecondIndex { get; set; }
        }
    }
}