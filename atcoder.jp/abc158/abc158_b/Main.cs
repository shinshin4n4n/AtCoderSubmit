using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoderPractice0802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] NAB = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = NAB[0];
            long A = NAB[1];
            long B = NAB[2];
            long ans = 0;


                long shou = N / (A + B);
                long mod = N % (A + B);

                if (A == 0)
                {
                    Console.WriteLine(ans);
                }
                else
                {
                if (mod >= A)
                {
                    Console.WriteLine(A * shou + A);
                }
                else
                {
                    Console.WriteLine(A * shou + mod);
                }

                }
            }
        }
    }
