namespace HackerRank._1_Week_Preparation.Day_2
{
    internal class LonelyInteger
    {
        class Result
        {

            /*
             * Complete the 'lonelyinteger' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER_ARRAY a as parameter.
             */

            public static int lonelyinteger(List<int> a)
            {
                int returno = 0;

                foreach (int i in a)
                {
                    List<int> listTemp = new List<int>(a);
                    listTemp.Remove(i);

                    if (!listTemp.Contains(i))
                    {
                        returno = i;
                    }
                }

                return returno;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                int result = Result.lonelyinteger(a);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
