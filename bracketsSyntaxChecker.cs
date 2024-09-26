using System;
using System.Collections.Generic;

namespace BracketSyntaxChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "({[]})";
            bool result = CheckBracketsSyntax(input);
            Console.WriteLine(result);
        }

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
                        stack.Push(c);
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
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
