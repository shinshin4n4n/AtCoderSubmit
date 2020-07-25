using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0725
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            if(X >=400 && X <= 599) { Console.WriteLine("8"); }
            if (X >= 600 && X <= 799) { Console.WriteLine("7"); }
            if (X >= 800 && X <= 999) { Console.WriteLine("6"); }
            if (X >= 1000 && X <= 1199) { Console.WriteLine("5"); }
            if (X >= 1200 && X <= 1399) { Console.WriteLine("4"); }
            if (X >= 1400 && X <= 1599) { Console.WriteLine("3"); }
            if (X >= 1600 && X <= 1799) { Console.WriteLine("2"); }
            if (X >= 1800 && X <= 1999) { Console.WriteLine("1"); }
      }

    }
}
