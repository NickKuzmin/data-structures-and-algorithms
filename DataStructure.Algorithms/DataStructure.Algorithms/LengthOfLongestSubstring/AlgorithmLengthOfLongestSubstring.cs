using System;
using System.Collections.Generic;

namespace DataStructure.Algorithms.LengthOfLongestSubstring
{
    public class AlgorithmLengthOfLongestSubstring
    {
        public int Execute(string @string)
        {
            if (string.IsNullOrEmpty(@string)) return 0;
            var set = new HashSet<char>();

            var start = 0;
            var end = 0;
            var maxLengh = 0;
            while (end < @string.Length)
            {
                if (!set.Contains(@string[end]))
                {
                    set.Add(@string[end++]);
                    maxLengh = Math.Max(maxLengh, set.Count);
                }
                else
                {
                    while (@string[start] != @string[end])
                    {
                        set.Remove(@string[start++]);
                    }
                    start++;
                    end++;
                }
            }

            return maxLengh;
        }
    }
}
