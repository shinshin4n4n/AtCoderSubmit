using System;

namespace AtCoder_Kaijou
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] av = Console.ReadLine().Split(' ');
            string[] bw = Console.ReadLine().Split(' ');
            int t = int.Parse(Console.ReadLine());

            long a = int.Parse(av[0]);
            long v = int.Parse(av[1]);
            long b = int.Parse(bw[0]);
            long w = int.Parse(bw[1]);
            long AT = a;
            long BT = b;

            //T秒後のAの位置 AT
            if (a < b)
            {
                AT = a + v * t;
                BT = b + w * t;

                if (AT >= BT)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                AT = a - v * t;
                BT = b - w * t;

                if (AT <= BT)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            }

        }
    }
