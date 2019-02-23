using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        public static void Direc(DirectoryInfo directory, string s)
        {
            FileInfo[] files = directory.GetFiles();//сохраняем информацию о файлах в папке
            DirectoryInfo[] directories = directory.GetDirectories();//сохраняем информацию о папках 
                int cnt = 0;
                foreach (DirectoryInfo dir in directories)
                {
                    
                    Console.WriteLine(dir.Name + " " + cnt);
                    Direc(dir, s);
                

                }
            foreach (FileInfo file in files)
                    {
                        if (file.Name.StartsWith(s) || dir.Name.StartsWith(s))
                        {
                            cnt++;
                        }
                        Console.WriteLine(file.Name);
                    }
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Arsen Zhaxygaliyev\Desktop\Новая папка");//сохраняем информацию о папке
            string s = Console.ReadLine();
            Direc(directory, s);

        }
    }
}