using System;

namespace DataStructure.Algorithms.AlgorithmIsValidPalindrome
{
    public class AlgorithmIsValidPalindrome
    {
        public bool IsPalindrome(string @string)
        {
            if (string.IsNullOrEmpty(@string))
            {
                return true;
            }

            for (int begin = 0, end = @string.Length - 1; begin <= end; begin++, end--)
            {
                while (begin < @string.Length && !char.IsLetterOrDigit(@string[begin]))
                {
                    begin++;
                }

                while (end >= 0 && !char.IsLetterOrDigit(@string[end]))
                {
                    end--;
                }

                if (begin >= @string.Length || end < 0)
                {
                    return true;
                }

                if (char.ToLower(@string[begin]) != char.ToLower(@string[end]))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPalindrome2(string @string)
        {
            for (int i = 0, j = @string.Length - 1; i < @string.Length / 2; i++, j--)
            {
                if (@string[i] != @string[j])
                {
                    return false;
                }
                else
                    return true;
            }

            return true;
        }
    }
}
