using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;
using static System.Console;

namespace action1
{
    class Program
    {
        public static event Action myOwnAction;

       static void Main(string[] args)
        {
            while (true)
            {
                string s1 = ReadLine();

                switch (s1)
                {
                    case "1":
                        myOwnAction += One;

                        break;
                    case "2":
                        myOwnAction += Two;

                        break;
                    case "3":
                        myOwnAction += Three;

                        break;
                    case "4":
                        myOwnAction?.Invoke();
                        break;
                    default:
                        break;

                }

                if (s1 == "n")
                {
                    break;
                }
            }

            ReadKey();
        } 

        static void One()
        {
            WriteLine("hi world");
        }
        static void Two()
        {
            WriteLine("hello world");
        }
        static void Three()
        {
            WriteLine("안녕");
        }
    }
    
}
