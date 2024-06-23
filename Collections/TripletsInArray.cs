using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public static class TripletsInArray
    {
        public static void Display()
        {
            //triplets of sum 8
            int[] intArray = { 1, 3, 4, 2, 8, 5, 9 };
            int[] brutForceResult = GetTripletsUsingBrutForce(intArray);
            int[] twoPointerResult = GetTripletsUsingTwoPointer(intArray);

            string str = "The Ultimate Test"; // character repeated thrice
            Console.WriteLine(FindThriceCharacter(str));

            string strWithUniqueTriplets = "ababbaccabccabbcca";
            Console.WriteLine(FindUniqueTriplets(strWithUniqueTriplets));
        }

        private static string FindUniqueTriplets(string str)
        {
            for (int i = 0; i < str.Length-2; i++)
            {
                if(str[i] != str[i + 1] && str[i] != str[i + 2] && str[i+1] != str[i+2])
                {
                    return str.Substring(i, 3);
                }
            }
            return string.Empty;
        }

        private static char FindThriceCharacter(string str)
        {
            Dictionary<char, int> charCountDictionary = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if(charCountDictionary.TryGetValue(c, out int count))
                {
                    charCountDictionary[c] = ++count;
                }
                else
                {
                    charCountDictionary[c] = 1;
                }
            }

            if (charCountDictionary.Count > 0)
            {
                return charCountDictionary.First(x => x.Value == 3).Key;
            }
            return '\0';

        }

        private static int[] GetTripletsUsingTwoPointer(int[] intArray)
        {
            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length; i++)
            {
                
                int left = i + 1;
                int right = intArray.Length - 1;
                while (left < right)
                {
                    if (intArray[i] + intArray[left] + intArray[right] == 8)
                    {
                        return new int[] { intArray[i], intArray[left], intArray[right] };
                    }
                    else if (intArray[i] + intArray[left] + intArray[right] < 8)
                    {
                        left++;
                    }
                    else if (intArray[i] + intArray[left] + intArray[right] > 8)
                    {
                        right--;
                    } 
                }
            }
            return null;
        }

        private static int[] GetTripletsUsingBrutForce(int[] intArray)
        {
            for(int i = 0; i< intArray.Length; i++)
            {
                for(int j = i+1; j< intArray.Length; j++)
                {
                    for (int k = j+1; k < intArray.Length; k++)
                    {
                        if(intArray[i] + intArray[j] + intArray[k] == 8)
                        {
                            return new int[]{ intArray[i], intArray[j], intArray[k] };
                        }
                    }
                }
            }
            return null;
        }
    }
}
