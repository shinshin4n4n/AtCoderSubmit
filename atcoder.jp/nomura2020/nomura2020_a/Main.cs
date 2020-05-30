using System;

namespace atcoder_nomura
{
    class MainClass
    {
        public static void Main(string[] args)
        {

                string[] input = Console.ReadLine().Split(' ');
                int H1 = int.Parse(input[0]);
                var M1 = int.Parse(input[1]);
                var H2 = int.Parse(input[2]);
                var M2 = int.Parse(input[3]);
                var K = int.Parse(input[4]);

                //起きている時間（分）
                var Oki = (H2 * 60 + M2) - (H1 * 60 + M1) - K;

                Console.WriteLine(Oki);
           
        }
    }

}
