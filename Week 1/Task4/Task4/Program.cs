using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s); // input string and the convert it into int 

            int[,] a = new int[n, n]; // declare double array 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                 Console.Write("[*]"); // output [*] 
                }
                Console.WriteLine(); // transfer to another line
            }

        } 
    }
}
