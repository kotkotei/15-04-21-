using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввод число ");
            int d = Convert.ToInt32(Console.ReadLine());
            int a = d % 10;
            int b = d / 100;
            int s = d / 10 % 10;
            if ((a == b) & (b == s) & (s == a))
            {
                Console.WriteLine("raven bich AAAAAA!!!!!!");
            }
            else
            {
                Console.WriteLine("no raven aaa!!!!1");
                if ((a == b) | (b == s) | (s == a))
                { Console.WriteLine("da"); }
                { Console.WriteLine("no"); }
            }
            Console.ReadKey();
        }
    }
}
