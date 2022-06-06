using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class FlippingBitsResult
    {
        /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

        public static long FlippingBits(long number)
        {
            //string number = "100";
            //int fromBase = 10;
            int toBase = 2;
            string result = Convert.ToString(number, toBase);
            Console.WriteLine("converted to binary: {0}", result);
            int flipNo = 1;
            long output = Convert.ToInt64(result, 2);
            Console.WriteLine("initial string before xor: {0}", output);

            Console.WriteLine(output);
            for (int i = result.Length - 1; i >= result.Length - flipNo; --i)
            { 
                output ^= 1 << i;
                Console.WriteLine("output: {0}", output);
            }

            Console.WriteLine(output);
            return output;
        }

        public static string ConvertDecimalToBinary(int decimalNumber)
        {
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }
    }
}
