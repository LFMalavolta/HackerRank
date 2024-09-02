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
    internal class Grid_Challenge
    {
        class Result
        {

            /*
             * Complete the 'gridChallenge' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING_ARRAY grid as parameter.
             */

            public static string gridChallenge(List<string> grid)
            {
                int tamanhoGrid = grid.Count;
                for (int i = 0; i < tamanhoGrid; i++)
                {
                    grid[i] = OrdemAlfabetica(grid[i]);
                }

                for (int col = 0; col < grid[0].Length; col++)
                {
                    for (int row = 0; row < tamanhoGrid - 1; row++)
                    {
                        if (grid[row][col] > grid[row + 1][col])
                        {
                            return "NO";
                        }
                    }
                }
                return "YES";
            }

            private static string OrdemAlfabetica(string item)
            {
                char[] chars = item.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int t = Convert.ToInt32(Console.ReadLine().Trim());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    int n = Convert.ToInt32(Console.ReadLine().Trim());

                    List<string> grid = new List<string>();

                    for (int i = 0; i < n; i++)
                    {
                        string gridItem = Console.ReadLine();
                        grid.Add(gridItem);
                    }

                    string result = Result.gridChallenge(grid);

                    textWriter.WriteLine(result);
                }

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
