using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Arsen Zhaxygaliyev\Desktop\new.txt");
            sw.Write("arsen");
            sw.Close();
            File.Copy(@"C:\Users\Arsen Zhaxygaliyev\Desktop\new.txt", @"C:\Users\Arsen Zhaxygaliyev\Desktop\new2.txt");
            File.Delete(@"C:\Users\Arsen Zhaxygaliyev\Desktop\new.txt");
        }
    }
}
