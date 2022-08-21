using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;

using static System.Console;

namespace qksthrrpdla
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int rnum = random.Next(0, 100); //랜덤값
            int answer; //y,n 답변
            int enter; //입력값
            Stopwatch stopwatch = new Stopwatch(); //타이머

            bool cheak = true;
            while (cheak)
            {

                int.TryParse(Console.ReadLine(), out enter);

                Console.WriteLine("화면에 뜨는 랜덤한 숫자가 입력한 숫자의 배수인 경우 y, 아닌 경우엔 n을 누르세요.");



                Console.WriteLine(rnum);
                stopwatch.Start();
                answer = char.Parse(Console.ReadLine());



                if (answer == 'y')
                {
                    if (rnum % enter == 0)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("정답입니다.");
                        Console.WriteLine($"걸린시간 : {stopwatch.ElapsedMilliseconds / 1000}초");
                    }
                    else if (rnum % enter != 0)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("오답입니다.");
                    }
                }
                if (answer == 'n')
                {
                    if (rnum % enter != 0)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("정답입니다.");
                        Console.WriteLine($"걸린시간 : {stopwatch.ElapsedMilliseconds / 1000}초");
                    }
                    else if (rnum % enter == 0)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("오답입니다.");
                    }
                }
                Console.WriteLine("다시하시겠습니까?");
                if (Console.ReadLine().ToUpper() == "y")
                {
                   
                }
                if (Console.ReadLine().ToUpper() == "n")
                {
                    cheak = false;
                    Console.WriteLine("종료 되었습니다.");
                }
            }

        }
    }
}
