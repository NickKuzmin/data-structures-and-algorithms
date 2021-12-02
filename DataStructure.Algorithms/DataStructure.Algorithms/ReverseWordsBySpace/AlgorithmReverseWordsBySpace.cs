namespace DataStructure.Algorithms.ReverseWordsBySpace
{
    public class AlgorithmReverseWordsBySpace
    {
        /// <summary>
        /// Time Complexity: O(n) 
        /// Auxiliary Space: O(1)
        /// </summary>
        public string Execute(string @string)
        {
            // Pointer to the first character
            // of the first word
            int start = 0;
            for (int i = 0; i < @string.Length; i++)
            {
                // If the current word has ended
                if (@string[i] == ' ' || i == @string.Length - 1)
                {
                    int end;
                    if (i == @string.Length - 1)
                        end = i;
                    else
                        end = i - 1;

                    // Reverse the current word
                    while (start < end)
                    {
                        @string = Swap(@string, start, end);
                        start++;
                        end--;
                    }

                    // Pointer to the first character
                    // of the next word
                    start = i + 1;
                }
            }

            return @string;
        }

        private string Swap(string @string, int i, int j)
        {
            char[] ch = @string.ToCharArray();
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;

            return string.Join("", ch);
        }
    }
}
