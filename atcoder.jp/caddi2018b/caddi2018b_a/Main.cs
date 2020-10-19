using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();

            int ans = 0;
            for(var i =0; i < 4; i++)
            {
                if (N[i] == '2') ans++;
            }
            Console.WriteLine(ans);
        }        
    }
