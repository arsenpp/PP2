using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime(int b) // функия для определения простого числа 
        {
            if (b == 1) return false;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) return false; // если число делится без остатка на числа от 0 до числа стоящего перед собой хотя бы 1 раз, то выводит false; 
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // ввод стринга и перевод в инт 
            //string s = Console.ReadLine();
            //int b = int.Parse(s);

            int[] a = new int[n]; // создаем массив 

            int cnt = 0; // счетчик равен нулю 

            for (int i = 0; i < n; i ++)  // цикл для заполнения массива 
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }


            for (int i = 0; i < n; i++) // если простое число счетчик увеличивается на один 
            {
                if (Prime(a[i]))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt); // вывод количества простых чисел 

            for(int i = 0; i < n; i++) // цикл для вывода простых чисел 
            {
                if (Prime(a[i]))
                {
                    Console.Write(a[i] + " "); // выводит i-тый член массива(если это число простое) + пробел 

                }
            }

        }
    }
}
