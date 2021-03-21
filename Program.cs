using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialCodility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x =  { 32,51712, 66561, 6291457, 74901729, 805306373, 1376796946, 1073741825, 1610612737 };
            for (int i = 0; i < x.Length; i++)
            {
                int result = solution(x[i]);

                Console.WriteLine(x[i] + " -> " + result); 
            }
        }

        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<int> PairResults = new List<int>();
            PairResults.Add(0);
            int length = 0;
            
            string binary = Convert.ToString(N, 2);
            length = binary.Length;

            List<int> indexNumbersForOnes = DetectOnes(binary);

            for (int i = 0; i < indexNumbersForOnes.Count-1; i++) //PairForOnes
            {
                PairResults.Add(indexNumbersForOnes[i+1] - indexNumbersForOnes[i] - 1); 
            }

            return PairResults.Max();
        }

        public static List<int> DetectOnes(string binary)
        {
            List<int> indexNumbersForOnes = new List<int>();

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] =='1')
                {
                    indexNumbersForOnes.Add(i);
                }
            }

            return indexNumbersForOnes;
        }

        

    }
}
