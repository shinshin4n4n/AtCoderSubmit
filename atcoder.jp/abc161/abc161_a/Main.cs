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
            int[] XYZ = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int X = XYZ[0];
            int Y = XYZ[1];
            int Z = XYZ[2];

            //ABC→BAC→BCA→YZX

            Console.Write(Z);
            Console.Write(" ");
            Console.Write(X);
            Console.Write(" ");
            Console.Write(Y);

        }
    }
}
