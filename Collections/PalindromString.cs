using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public static class PalindromString
    {
        public static void Display()
        {
            string pString = "arabbara";
            string pText = "black makes black";

            int pNumber = 10012001;

            Console.WriteLine("pString is Palindrom: {0}", IsPalindromString(pString));
            Console.WriteLine("pString is Palindrom: {0}", CanPalindromString(pString));
            Console.WriteLine("pString is Palindrom: {0}", IsPalindromText(pText));
            Console.WriteLine("pString is Palindrom: {0}", IsPalindromNumber(pNumber));

        }

        private static bool CanPalindromString(string pString)
        {
            //aabbaa
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            foreach(char c in pString)
            {
                if (charDictionary.TryGetValue(c, out int count))
                {
                    charDictionary[c] = ++count;
                }
                else
                {
                    charDictionary[c] = 1;
                }
            }
            var unPairedChar = charDictionary.Where(x => x.Value == 1);
            if(unPairedChar.Count() > 1)
            {
                return false;
            }
            return true;
        }

        private static bool IsPalindromString(string pString)
        {
            int left = 0;
            int right = pString.Length - 1;
            while (left<=right)
            {
                if(pString[left] == pString[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

        private static bool IsPalindromText(string pText)
        {
            string[] pTextArray = pText.Split(" ");
            int left = 0;
            int right = pTextArray.Length - 1;
            while (left <= right)
            {
                if (pTextArray[left] == pTextArray[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsPalindromNumber(int pNumber)
        {
            /*
             * it can be also done by converting it to string
             * Console.WriteLine("PalindromNumber: {0}", IsPalindromString(pNumber.ToString()));
             */
            
            int reverseNumber = GetReverseNumber(pNumber);
            if(pNumber == reverseNumber)
            {
                return true;
            }
            return false;
        }

        private static int GetReverseNumber(int pNumber)
        {
            if (pNumber < 10)
            {
                return pNumber;
            }

            int returnValue = 0;
            while (0 < pNumber / 10)
            {
                returnValue = (returnValue * 10 + (pNumber % 10));
                pNumber /= 10;
            }
            return returnValue * 10 + pNumber;
        }
    }
}
