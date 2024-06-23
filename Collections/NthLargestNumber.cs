using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public static class NthLargestNumber
    {
        public static void Display()
        {
            int[] array = { 2, 1, 5, 3, 6, 8, 7, 9 };
            Console.WriteLine(LargestNumber(array));
            Console.WriteLine(SecondLargestNumber(array));
            Console.WriteLine(ThirdLargestNumber(array));
            Console.WriteLine(KthLargestNumber(array,3));
        }

        private static int LargestNumber(int[] array)
        {
            int largestNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i]>largestNumber)
                {
                    largestNumber = array[i];
                }
            }
            return largestNumber;
        }

        private static int SecondLargestNumber(int[] array)
        {
            int first = int.MinValue;
            int second = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] > second)
                {
                    first = second;
                    second = array[i];
                }
            }
            return second;
        }

        private static int ThirdLargestNumber(int[] array)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int third = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > third)
                {
                    first = second;
                    second = third;
                    third = array[i];
                }
            }
            return third;
        }

        private static int KthLargestNumber(int[] array, int length)
        {
            //length = 3;
            //{ 2, 1, 5, 3, 6, 8, 7, 9 };
            List<int> resultList = new List<int>(array.Distinct().Take(length));
            //{ 3, 5, 6}
            resultList.Sort();
            for (int i = length-1; i < array.Length; i++)
            {
                if(array[i] > resultList[length - 1])
                {
                    resultList.RemoveAt(0);
                    resultList.Add(array[i]);
                }

                if (array[i] > resultList[0])
                {
                    resultList.RemoveAt(0);
                    resultList.Add(array[i]);
                    resultList.Sort();
                }
            }
            return resultList[0];
        }
    }
}
