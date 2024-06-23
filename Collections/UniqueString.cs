using System;

namespace Collections
{
    public static class UniqueString
    {
        public static void Display()
        {
            // program to return unique string from array
            string[] cars = { "Volvo", "Volvo", "Honda" };
            Console.WriteLine(GetUniqueString(cars));

            string str = "CAPITALISTIC";
            Console.WriteLine(GetUniqueCharacter(str));

            int[] numbers = { 1, 4, 2, 3, 2, 5, 7, 1, 4 };
            Console.WriteLine(GetUniqueNumber(numbers));
        }

        private static int GetUniqueNumber(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                if (Array.IndexOf(numbers, numbers[index]) == Array.LastIndexOf(numbers, numbers[index]))
                {
                    return numbers[index];
                }
            }
            return -1;
        }

        private static char GetUniqueCharacter(string str)
        {
            for (int index = 0; index < str.Length; index++)
            {
                if (str.IndexOf(str[index]) == str.LastIndexOf(str[index]))
                {
                    return str[index];
                }
            }
            return '\0';
        }

        private static string GetUniqueString(string[] strArray)
        {
            for (int index = 0; index < strArray.Length; index++)
            {
                if (Array.IndexOf(strArray, strArray[index]) == Array.LastIndexOf(strArray, strArray[index]))
                {
                    return strArray[index];
                }
            }
            return null;
        }
    }
}
