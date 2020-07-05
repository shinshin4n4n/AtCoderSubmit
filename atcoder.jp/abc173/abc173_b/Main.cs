using System;
using System.Linq;

namespace AtCoder0705
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] S = new string[N];
            for(var i =0; i<N; i++)
            {
                S[i] = Console.ReadLine();
            }

            int ac = 0;
            int wa = 0;
            int tle = 0;
            int re = 0;

            for(var i = 0; i<N; i++)
            {
                if (S[i] == "AC") { ac++; }
                if (S[i] == "WA") { wa++; }
                if (S[i] == "TLE") { tle++; }
                if (S[i] == "RE") { re++; }
            }

            Console.WriteLine("AC x " +ac);
            Console.WriteLine("WA x " +wa);
            Console.WriteLine("TLE x " +tle);
            Console.WriteLine("RE x " +re);

        }
    }
}
