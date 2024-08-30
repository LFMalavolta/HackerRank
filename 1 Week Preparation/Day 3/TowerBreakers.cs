namespace HackerRank._1_Week_Preparation.Day_3
{
    internal class TowerBreakers
    {
        class Result
        {

            /*
             * Complete the 'towerBreakers' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. INTEGER m
             */

            public static int towerBreakers(int n, int m)
            {
                // Se todas as torres têm altura 1, o jogador 2 sempre vence
                if (m == 1)
                {
                    return 2;
                }

                // Se o número de torres for par, o jogador 2 sempre vence
                // Se o número de torres for ímpar, o jogador 1 sempre vence
                return n % 2 == 0 ? 2 : 1;
            }

            public static int towerBreakers2(int n, int m)
            {
                int turn = 1;

                List<int> towers = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    towers.Add(m);
                }

                for (int i = 0; i < towers.Count; i++)
                {
                    int tower = towers[i];
                    while (tower != 1)
                    {
                        for (int number = tower / 2; number >= 1; number--)
                        {
                            if (tower % number == 0)
                            {
                                tower /= number;
                                break;
                            }
                        }
                        turn = turn == 1 ? 2 : 1;
                    }
                }
                return turn;
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
                    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                    int n = Convert.ToInt32(firstMultipleInput[0]);

                    int m = Convert.ToInt32(firstMultipleInput[1]);

                    int result = Result.towerBreakers(n, m);

                    textWriter.WriteLine(result);
                }

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
