using System;

namespace Collections
{
    public static class Factorial
    {
        public static void Display()
        {
            int input = 5;
            int loopFactorial = GetFactorialUsingLoop(input);
            int recursionFactorial = GetFactorialUsingRecusion(input);
            Console.WriteLine("loopFactorial: {0}", loopFactorial);
            Console.WriteLine("recursionFactorial: {0}", recursionFactorial);
        }
        private static int GetFactorialUsingLoop(int input)
        {
            int result = 1;
            for(int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }
        private static int GetFactorialUsingRecusion(int input)
        {
            if(input <= 1)
            {
                return input;
            }
            return input * GetFactorialUsingRecusion(input - 1);
        }
    }
}
