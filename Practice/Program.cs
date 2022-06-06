using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            //Console.WriteLine("Decimal:{0}, Binary: {1}",q, FlippingBitsResult.ConvertDecimalToBinary(q));

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());



                long result = FlippingBitsResult.FlippingBits(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
            Console.ReadLine();
        }
    }
}
