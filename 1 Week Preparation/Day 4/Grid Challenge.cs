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
                string alfabeto = "abcdefghijklmnopqrstuvwxyz";

                for (int i = 0; i < grid.Count; i++)
                {
                    string item = grid[i];
                    item = OrdemAlfabetica(item);
                }

                for (int i = 0; i < grid.Count; i++)
                {
                    for (int j = 0; j < grid.Count; j++)
                    {
                        int indexAlfabeto = alfabeto.IndexOf(grid[i][j]);
                        int indexAlfabetoComparar = alfabeto.IndexOf(grid[i + 1][j]);
                    }
                }
                return "YES";
            }

            private static string OrdemAlfabetica(string item)
            {
                char[] chars = item.ToArray();
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
