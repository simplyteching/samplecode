using System;
using System.Linq;

namespace Collections
{
    public static class RemoveDuplicateFromArray
    {
        public static void Display()
        {
            int[] arrayWithDuplicates = { 1, 2, 2, 3, 3, 4, 5, 6, 6, 6, 7, 8 };
            int[] uniqueArray = RemoveDuplicates(arrayWithDuplicates);

            foreach (int value in arrayWithDuplicates)
            {
                Console.Write(value + ", ");
            }
            Console.WriteLine();
            foreach (int value in uniqueArray)
            {
                Console.Write(value + ", ");
            }

        }

        private static int[] RemoveDuplicates(int[] array)
        {
            int ci = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[ci - 1] != array[i])
                {
                    array[ci++] = array[i];
                }
            }
            return array.Take(ci).ToArray();
        }
    }
}
