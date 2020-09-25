using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int[]> input = new List<int[]>();
            int cnt = 0;
            bool flg = false;

            for(var i =0; i< N; i++)
            {
                int[] d = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                input.Add(d);
            }

            for(var i =0; i< N; i++)
            {
                if (input[i][0] == input[i][1])
                {
                    cnt++;
                    flg = true;
                    if (cnt >= 3) break;
                }
                else
                {
                    cnt = 0;
                    flg = false;
                }
            }

            if(cnt >= 3 && flg)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }
        }
    }
}
