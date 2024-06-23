using System;
using System.Collections.Generic;

namespace Collections
{
    public static class ReverseString
    {
        public static void Display()
        {
            string str = "The City Is Beautiful";

            //Beautiful Is City The
            Console.WriteLine(GetStringByReverseWord(str));

            //ehT ytiC sI lufituaeB
            Console.WriteLine(GetStringByReverseLetterOfWords(str));

            //lufituaeB sI ytiC ehT
            Console.WriteLine(GetReverseByLetter(str));
        }

        //The City Is Beautiful
        //Beautiful Is City The
        private static string GetStringByReverseWord(string str)
        {
            string[] strArray = str.Split(" ");
            List<string> result = new List<string>();
            for(int i = strArray.Length - 1; i>=0; i--)
            {
                result.Add(strArray[i]);
            }
            return string.Join(" ", result);
        }

        //The City Is Beautiful
        //ehT ytiC sI lufituaeB
        private static string GetStringByReverseLetterOfWords(string str)
        {
            string[] strArray = str.Split(" ");
            List<string> result = new List<string>();
            for (int i = 0; i < strArray.Length; i++)
            {
                var charArray = strArray[i].ToCharArray();
                result.Add(GetLetterReverse(charArray));
            }
            return string.Join(" ", result);
        }

        private static string GetLetterReverse(char[] charArray)
        {
            List<char> charList = new List<char>();
            for(int i = charArray.Length-1; i >= 0; i--)
            {
                charList.Add(charArray[i]);
            }
            return new string(charList.ToArray());
        }

        //The City Is Beautiful
        //lufituaeB sI ytiC ehT
        private static string GetReverseByLetter(string str)
        {
            List<char> charList = new List<char>();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                charList.Add(str[i]);
            }
            return new string(charList.ToArray());
        }
    }
}
