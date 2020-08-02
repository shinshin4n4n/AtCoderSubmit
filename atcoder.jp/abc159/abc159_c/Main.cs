using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoderPractice0802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //abcの最大値は、L^3/27 

            double L = Double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(L, 3) / 27);

             
            }
        }
    }
