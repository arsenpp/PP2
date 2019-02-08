using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s); // input the string and then convert it to int 

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());

                a[i] = c;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");
            }

        }
    }
}
