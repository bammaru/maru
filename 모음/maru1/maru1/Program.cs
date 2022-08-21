using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace maru1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();



            WriteLine("Hello world.");
            WriteLine();
            WriteLine();

            int i1 = 3;
            string s1 = "hi";

            Console.WriteLine("{0} {1}", i1, s1);
            Console.WriteLine($"{i1} {s1}");
            Console.WriteLine(i1 + " " + s1);

            Console.ReadKey();
        }
    }
   
}
