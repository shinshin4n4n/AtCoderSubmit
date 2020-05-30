using System;

using System.Linq;

namespace atcoder_nomura
{
    public class Postdocs
    {
        public static void Main(string[] args) 
        {
            string input = Console.ReadLine();

            string inputpd = input.Replace("?", "D");

            Console.WriteLine(inputpd);
            //Console.WriteLine(PD(inputpd));


        }

        public static int PD(string s) {
            int pd = CountOf(s, "D","PD");
            return pd;
        }
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }

        public static int CountOf(string target, params string[] strArray)
        {
            int count = 0;

            foreach (string str in strArray)
            {
                int index = target.IndexOf(str, 0);
                while (index != -1)
                {
                    count++;
                    index = target.IndexOf(str, index + str.Length);
                }
            }

            return count;
        }
    }
}
