using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            long[] a = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            if(a[0] + a[1] + a[2] >= 22)
            {
                Console.WriteLine("bust");
            }else
            {
                Console.WriteLine("win");
            }

            //Console.ReadKey(true);
        }
    }
