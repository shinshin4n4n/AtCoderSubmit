using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
        int[] AB = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int A = AB[0];
        int B = AB[1];
        int C = AB[2];

        if ((C - A) * (B - C) > 0)
        {
            Console.WriteLine("Yes");
        }else
        {
            Console.WriteLine("No");
        }
        //Console.ReadKey(true);
    }
                
  }
