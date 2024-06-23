using System;

namespace Collections
{
    public static class Fibonacci
    {
        //nth Fibonacci number
        // 0 1 1 2 3 5 8 13...  
        public static void Display()
        {
            int input = 7;
            int fibbonacciUsingLoop = GetFibonacciUsingLoop(input);
            int fibbonacciUsingRecursion = GetFibonacciUsingRecursion(input);
            Console.WriteLine("fibbonacciUsingLoop: {0}", fibbonacciUsingLoop);
            Console.WriteLine("fibbonacciUsingRecursion: {0}", fibbonacciUsingRecursion);
        }
        private static int GetFibonacciUsingLoop(int input)
        {
            // 0 1 1 2 3 5 8
            if (input < 2)
            {
                return input;
            }
            int previousNumber = 0;
            int currentNumber = 1;
            int result = 1;
            for(int i = 2; i <= input; i++)
            {
                result = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = result;
                /***
                 * currentNumber = previousNumber + currentNumber;
                 * previousNumber = currentNumber - previousNumber;
                ***/
            }
            return result;
        }

        private static int GetFibonacciUsingRecursion(int input)
        {
            // 0 1 1 2 3 5 8
            if(input < 2)
            {
                return input;
            }
            return GetFibonacciUsingRecursion(input - 1) + GetFibonacciUsingRecursion(input - 2);
        }

    }
}
