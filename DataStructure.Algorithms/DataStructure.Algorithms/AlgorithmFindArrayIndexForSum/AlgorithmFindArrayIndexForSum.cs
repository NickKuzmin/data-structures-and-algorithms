using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Algorithms.FindArrayIndexesForSum
{
    public class AlgorithmFindArrayIndexForSum
    {
        public AlgorithmFindArrayIndexForSumResult FindArrayIndexForSum(int[] array, int searchValue)
        {
            var results = new List<Tuple<int, int>>();

            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < array.Length; i++)
            {
                var rest = searchValue - array[i];

                if (dictionary.ContainsKey(rest))
                {
                    results.Add(new Tuple<int, int>(i, dictionary[rest]));
                }
                else
                {
                    dictionary[array[i]] = i;
                }
            }

            var result = results.FirstOrDefault();
            return new AlgorithmFindArrayIndexForSumResult
            {
                IsFound = result != null,
                FirstIndex = result?.Item1,
                SecondIndex = result?.Item2
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