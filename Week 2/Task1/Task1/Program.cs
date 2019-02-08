using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Program
    {
        static bool Poli(string a) // function that checks for polindrome 
        {
            for (int i = 0; i < a.Length /2;i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;
            }
            return true; 
        }
        static void Main(string[] args)
        {
            StreamReader c = new StreamReader(@"C:\Users\Arsen Zhaxygaliyev\Desktop\PP2\Week 2\Task1\polindrome.txt"); // creates object that will read from the text 
            string s = c.ReadToEnd(); // read and save it to c 
            if (Poli(s)==true)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
