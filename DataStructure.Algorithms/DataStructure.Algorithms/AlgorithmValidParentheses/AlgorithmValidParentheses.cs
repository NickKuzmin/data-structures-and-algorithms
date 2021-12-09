using System.Collections.Generic;

namespace DataStructure.Algorithms.AlgorithmValidParentheses
{
    public class AlgorithmValidParentheses
    {
        public bool Execute(string @string)
        {
            if (@string == null || @string.Length % 2 != 0)
                return false;

            var stack = new Stack<char>();
            foreach (var @char in @string)
            {
                if (@char == '(')
                    stack.Push(')');
                else if (@char == '[')
                    stack.Push(']');
                else if (@char == '{')
                    stack.Push('}');
                else
                {
                    if (stack.Count == 0 || stack.Pop() != @char)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
