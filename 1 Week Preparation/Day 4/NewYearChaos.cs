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
    internal class NewYearChaos
    {
        class Result
        {

            /*
             * Complete the 'minimumBribes' function below.
             *
             * The function accepts INTEGER_ARRAY q as parameter.
             */

            public static void minimumBribes(List<int> q)
            {
                List<int> listaOrdem = new List<int>(q);
                listaOrdem.Sort();


            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                int t = Convert.ToInt32(Console.ReadLine().Trim());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    int n = Convert.ToInt32(Console.ReadLine().Trim());

                    List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

                    Result.minimumBribes(q);
                }
            }
        }
    }
}
