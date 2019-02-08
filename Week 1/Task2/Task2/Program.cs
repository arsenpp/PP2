using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // create a class Student 
    {
        string name; // describing of variables 
        string id;
        int yearofstudy;

        public Student(string a,string b) // create a constructor 
        {
            name = a;
            id = b;
        }
        public void showdata() // function that shows name and id 
        {
            Console.WriteLine("Student's name is: " + name + "\n" + "Student's id is: " + id );
        }

        public int nextYear(int c) // function that increment the year by 1 
        {
            yearofstudy = c;
            return yearofstudy + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name: "); 
            string sname = Console.ReadLine();         // input of name 
            Console.WriteLine("Input your id: ");
            string sid = Console.ReadLine(); // input of id 
            Console.WriteLine("Input your year of study: ");
            int sYear;

            string num = Console.ReadLine(); // input string type of year of study 
            bool result = false;
            while (!result) // while result true 
            {
                result = int.TryParse(num, out sYear); // converting of string to int 
                if (result) break; // if converting is success result is true and the loop breaks 
                Console.WriteLine("ERROR, input a number !"); // else the error message exists
                num = Console.ReadLine();
            }
            sYear = int.Parse(num); 
            Student s = new Student(sname, sid);
            s.showdata();
            Console.WriteLine("Next year of study: " + s.nextYear(sYear));
        }
    }
}
