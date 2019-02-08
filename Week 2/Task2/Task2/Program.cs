
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool prime (int n) // function to check the prime numbers 
        {
            if (n==1 || n==0) return false;
            for (int i = 2; i<=n/2;i++)
            {
                if (n%i==0) return false;
            }
            return true;
        }   

        static void Main(string[] args)
        {
           StreamReader sr = new StreamReader(@"C:\Users\Arsen Zhaxygaliyev\Desktop\PP2\Week 2\Task2\1.txt"); // object which reads the text 
            StreamWriter sw = new StreamWriter(@"C:\Users\Arsen Zhaxygaliyev\Desktop\PP2\Week 2\Task2\out.txt"); // object which writes to the file 
            string n = sr.ReadLine(); // reads to string 
            string[] array = n.Split(' '); // declaration of the array and split string n 
            foreach(string s in array)
            {
                if (prime(int.Parse(s)))
                sw.Write(s+" ");        
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}
