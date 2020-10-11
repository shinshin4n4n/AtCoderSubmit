using System;
using System.Linq;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Net.Sockets;


    class ARC105
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            long[] ABCD = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long A = ABCD[0];
            long B = ABCD[1];
            long C = ABCD[2];
            long D = ABCD[3];
        bool flg = false;

        //1枚とるとき、２枚とるときそれぞれで考える
        if( A == B+C+D ||
             B == A + C + D ||
             C == D + A + C ||
             D == A + C + B)
        {
            flg = true;
        }

        if( A + B == C+ D ||
             A + C == B + D ||
             A + D == B + C)
        {
            flg = true;
        }

        if (flg)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        }
    }
