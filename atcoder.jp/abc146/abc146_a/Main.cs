using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            if (S == "SAT") Console.WriteLine(1);
            if (S == "FRI") Console.WriteLine(2);
            if (S == "THU") Console.WriteLine(3);
            if (S == "WED") Console.WriteLine(4);
            if (S == "TUE") Console.WriteLine(5);
            if (S == "MON") Console.WriteLine(6);
            if (S == "SUN") Console.WriteLine(7);

        }
    }
}
