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

namespace HackerRank._1_Week_Preparation.Day_4
{
    internal class Recursive_Digit_Sum
    {
        class Result
        {

            /*
             * Complete the 'superDigit' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. STRING n
             *  2. INTEGER k
             */

            public static int superDigit(string n, int k)
            {
                StringBuilder super = new();
                for (int i = 0; i < k; i++)
                {
                    super.Append(n);
                }

                int soma = 0;   
                while (super.Length > 1)
                {
                    soma = 0;
                    foreach (char numero in super.ToString())
                    {
                        soma += int.Parse(numero.ToString());
                        Console.WriteLine($"{numero} -> soma: {soma}");
                    }
                    super = new StringBuilder(soma.ToString());
                    Console.WriteLine(super);
                };

                return (int)soma;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string n = firstMultipleInput[0];

                int k = Convert.ToInt32(firstMultipleInput[1]);

                int result = Result.superDigit(n, k);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
