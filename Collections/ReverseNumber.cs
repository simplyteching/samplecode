using System;

namespace Collections
{
    public static class ReverseNumber
    {
        public static void Display()
        {
            int input = 12345;
            Console.WriteLine(Reverse(input));
        }

        private static int Reverse(int input)
        {
            if(input < 10)
            {
                return input;
            }

            int returnValue = 0;
            while(0 < input/10)
            {
                returnValue = (returnValue * 10 + (input % 10));
                input /= 10;
            }
            return returnValue * 10 + input;
        }
    }
}
