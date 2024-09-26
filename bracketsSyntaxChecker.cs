using System;
using System.Collections.Generic;

namespace BracketSyntaxChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "(s{s}s[klkljsdf]sd)";
            bool result = CheckBracketsSyntax(input);
            Console.WriteLine(result);
        }

        // Check if the brackets in the input string are balanced
        private static bool CheckBracketsSyntax(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(c); // Push opening brackets
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[') return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{') return false;
                        break;

                    default:
                        break; // Ignore other characters
                }
            }

            return stack.Count == 0; // Return true if all brackets match
        }
    }
}
