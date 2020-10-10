using System;
using System.Linq;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace kyodai
{
    class kyodai
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            if(S == "Y")
            {
                Console.WriteLine(T.ToUpper());
            }
            else
            {
                Console.WriteLine(T);
            }





            Console.WriteLine("");
        }
    }
}
