using System;
using System.Linq;

namespace AtCoderPractic0718
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int YY = int.Parse(s.Substring(0,2));
            int MM = int.Parse(s.Substring(2, 2));

            if(MMcheck(YY) && MMcheck(MM))
            {
                Console.WriteLine("AMBIGUOUS");
            }

            if (!MMcheck(YY) && MMcheck(MM))
            {
                Console.WriteLine("YYMM");
            }
            if (MMcheck(YY) && !MMcheck(MM))
            {
                Console.WriteLine("MMYY");
            }
            if (!MMcheck(YY) && !MMcheck(MM))
            {
                Console.WriteLine("NA");
            }

        }

        public static bool MMcheck(int MM)
        {
            if(MM >=1 && MM <= 12)
            {
                return true;
            }
            else { return false; }
        }

    }
}
