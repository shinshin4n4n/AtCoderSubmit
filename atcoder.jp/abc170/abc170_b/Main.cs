using System;

namespace AtCoder0614
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            //鶴の数T　亀の数Kとして
            int cnt = 0; //個数判定

            for (var t = 0; t <= X; t++)
            {
                for (var k = 0; k <= X - t; k++)
                {
                    if (t + k == X && 2 * t + 4 * k == Y)
                    {
                        cnt++;
                    }
                }
            }

            if (cnt == 0)
            {
                Console.WriteLine("No");
            }
            else {
                Console.WriteLine("Yes");
            }


        }
    }
}

