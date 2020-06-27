using System;

namespace AtCoder0627
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            char[] sc = s.ToCharArray();
            char[] tc = t.ToCharArray();

            int ans = 0;

            for(var i =0; i<sc.Length; i++)
            {
                if(sc[i] != tc[i]) { ans++; }
            }

            Console.WriteLine(ans);
        }
    }
}
