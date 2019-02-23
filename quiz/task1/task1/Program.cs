
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\Users\Arsen Zhaxygaliyev\Desktop\Новая папка\");
            FileSystemInfo[] a = dir1.GetFileSystemInfos();
            foreach(FileSystemInfo files in a)
            {
                if (a.Length % 2 != 0) Console.WriteLine(files + " "); 
            }
        
        }
    }
}

