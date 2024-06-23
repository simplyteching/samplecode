using System;
using System.Collections.Generic;

namespace Collections
{
    public static class BracketPairs
    {
        public static void Display()
        {
            string bracketsValid = "{[({})]}";
            string bracketsInValid1 = "[(}{)]";
            string bracketsInValid2 = "{[[]}";

            Console.WriteLine("{0} is Vaid: {1}", bracketsValid, IsValidPairs(bracketsValid));
            Console.WriteLine("{0} is Vaid: {1}", bracketsInValid1, IsValidPairs(bracketsInValid1));
            Console.WriteLine("{0} is Vaid: {1}", bracketsInValid2, IsValidPairs(bracketsInValid2));
        }

        private static bool IsValidPairs(string brackets)
        {
            Stack<char> pairStack = new Stack<char>();
            foreach (char pair in brackets)
            {
                if (IsOpeningPair(pair))
                {
                    pairStack.Push(pair);
                }
                else if(pairStack.Count != 0)
                {
                    if(GetClosingPair(pairStack.Peek()) == pair)
                    {
                        pairStack.Pop();
                    }
                }
            }
            if(pairStack.Count == 0)
            {
                return true;
            }
            return false;

        }
        private static bool IsOpeningPair(char pair)
        {
            switch(pair)
            {
                case '{':
                case '[':
                case '(':
                    return true;
                default:
                    return false;
            }
        }
        private static char GetClosingPair(char openingPair)
        {
            switch(openingPair)
            {
                case '{':
                    return '}';
                case '(':
                    return ')';
                default:
                    return ']';
            }

        }
    }
}
