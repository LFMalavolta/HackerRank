using System.Linq;

namespace HackerRank._1_Week_Preparation.Day_2
{
    internal class CountingSort1
    {
        class Result
        {

            /*
             * Complete the 'countingSort' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static List<int> countingSort(List<int> arr)
            {
                long size = 100;

                List<int> result = new();
                for (int i = 0; i < size; i++)
                {
                    result.Add(0);
                }

                foreach (int number in arr)
                {
                    result[number] += 1;
                }

                return result;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> result = Result.countingSort(arr);

                textWriter.WriteLine(String.Join(" ", result));

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
