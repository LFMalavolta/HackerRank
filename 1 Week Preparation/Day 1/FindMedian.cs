using System.Linq;

namespace HackerRank._1_Week_Preparation.Day_2
{
    internal class FindMedian
    {
        class Result
        {

            /*
             * Complete the 'countingSort' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static int findMedian(List<int> arr)
            {
                arr.Sort();
                int size = arr.Count;
                return arr[size / 2];
            }


        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                int result = Result.findMedian(arr);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
