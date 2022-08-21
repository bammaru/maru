using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeStar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            int num;

            num = int.Parse(Console.ReadLine());
             
            for(i=0; i<num; i++){
                for (j = 0; j < (num - i - 1); j++){
                    Console.WriteLine(" ");
                }
                for (k=0; k<=i; k++){
                    Console.Write("*");
                }
                for(l=0; l<i; l++) {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
        
    }
}
