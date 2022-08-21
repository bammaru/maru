using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using static System.Console;

namespace StarMake1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Write("*");
                }
                for (int k = 0; k < i * 2; k++)
                {
                    Write(" ");
                }
                for (int l = 5; l > i; l--)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}

