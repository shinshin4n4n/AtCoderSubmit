using System;
using System.Linq;

namespace AtCoderPractice0802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] AB = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            double A = AB[0];
            double B = AB[1];
            int cnt = 0;
            int ans = 0;
            //せいぜい１万円まで

            for(var i = 1; i <=10000;i++)
            {
                int X = (int)(i * 0.08);
                int Y = (int)(i * 0.10);

                if(A == X && Y == B)
                {
                    ans = i;
                    cnt++;
                    break;
                }

            }

            if(cnt != 0)
            {
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
