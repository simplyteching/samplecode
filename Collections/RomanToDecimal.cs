using System;
using System.Collections.Generic;

namespace Collections
{
    public static class RomanToDecimal
    {
        public static void Display()
        {
            string romanValue = "XXXIV";
            int decimalValue = GetDecimal(romanValue);

            Console.WriteLine(decimalValue);
        }

        private static int GetDecimal(string romanValue)
        {
            Dictionary<char, int> dToRDict = new Dictionary<char, int>();
            dToRDict.Add('I',1);
            dToRDict.Add('V',5);
            dToRDict.Add('X',10);
            dToRDict.Add('L',50);
            int result = 0;
            for(int i = 0; i < romanValue.Length-1; i++)
            {
                if(dToRDict[romanValue[i]] < dToRDict[romanValue[i + 1]])
                {
                    result += dToRDict[romanValue[i + 1]] - dToRDict[romanValue[i]];
                    i++;
                }else
                {
                    result += dToRDict[romanValue[i]];
                }
            }
            return result;
        }
    }
}
