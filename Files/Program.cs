using System;
using System.IO;
using System.Linq;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var newfilepath = @"/Users/giorgishushanashvili/Projects/New-Homework/Files/newfile.txt";

            if (!File.Exists(newfilepath))
            {
                FileStream fs = File.Create(newfilepath);
            }
            else { Console.WriteLine("file already exists"); }

            StreamWriter sw = new StreamWriter(newfilepath);

            Console.WriteLine("enter the number of lines you want: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine(" enter text:");
                string str = Console.ReadLine();
                sw.WriteLine(str);


            }
            sw.Close();
            string last = File.ReadAllLines(newfilepath).Last(); ;
            Console.WriteLine(last);


            Console.ReadLine();
        }
    }
}

