namespace HackerRank._1_Week_Preparation.Day_3;
class CaesarCipher
{

    class Result
    {

        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string resultado = "";

            for (int letra = 0; letra < s.Length; letra++)
            {
                char letraMinuscula = char.ToLower(s[letra]);
                if (alfabeto.Contains(letraMinuscula))
                {
                    int posicaoLetra = alfabeto.IndexOf(letraMinuscula);
                    int novaPosicao = (posicaoLetra + k) % alfabeto.Length;

                    char novaLetra = alfabeto[novaPosicao];

                    bool eMaiuscula = char.IsUpper(s[letra]);
                    novaLetra = eMaiuscula ? char.ToUpper(novaLetra) : novaLetra;

                    resultado += novaLetra;
                }
                else
                {
                    resultado += s[letra];
                }
            }
            return resultado;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.caesarCipher(s, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
