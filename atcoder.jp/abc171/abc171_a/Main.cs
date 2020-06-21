using System;

namespace AtCoder0621
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char inpc = input[0];
            if (char.IsUpper(inpc))
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("a");
            }
        }
    }
}
