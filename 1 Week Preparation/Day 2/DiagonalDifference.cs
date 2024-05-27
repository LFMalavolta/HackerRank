namespace HackerRank._1_Week_Preparation.Day_2
{
    internal class DiagonalDifference
    {
        class Result
        {

            /*
             * Complete the 'diagonalDifference' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts 2D_INTEGER_ARRAY arr as parameter.
             */

            public static int diagonalDifference(List<List<int>> arr)
            {
                int sizeLine = arr.Count;

                int leftRightD = 0;
                int rightLeftD = 0;
                int position = 0;

                foreach (var item in arr) 
                {
                    leftRightD += item[0 + position];
                    rightLeftD += item[(sizeLine - 1) - position];

                    position++;
                }

                int retorno = rightLeftD - leftRightD;
                if (retorno < 0) 
                    retorno *= -1;

                return retorno;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<List<int>> arr = new List<List<int>>();

                for (int i = 0; i < n; i++)
                {
                    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                }

                int result = Result.diagonalDifference(arr);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
