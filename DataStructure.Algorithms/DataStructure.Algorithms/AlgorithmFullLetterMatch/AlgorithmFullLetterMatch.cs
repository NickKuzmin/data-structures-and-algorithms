using System.Collections.Generic;

namespace DataStructure.Algorithms.AlgorithmFullLetterMatch
{
    public class AlgorithmFullLetterMatch
    {
        public bool IsMatch(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
                return false;

            var dictionary1 = new Dictionary<char, int>();
            var dictionary2 = new Dictionary<char, int>();
            for (var i = 0; i < firstString.Length; i++)
            {
                if (dictionary1.ContainsKey(firstString[i]))
                {
                    dictionary1[firstString[i]]++;
                }
                else
                {
                    dictionary1.Add(firstString[i], 1);
                }

                if (dictionary2.ContainsKey(secondString[i]))
                {
                    dictionary2[secondString[i]]++;
                }
                else
                {
                    dictionary2.Add(secondString[i], 1);
                }
            }

            for (var i = 0; i < firstString.Length; i++)
            {
                if (dictionary1[firstString[i]] != dictionary2[firstString[i]])
                {
                    return false;
                }
            }

            return true;
        }
    }
}