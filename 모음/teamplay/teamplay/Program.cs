using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace namestudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = new string[5];
            s1[0] = "황수연";
            s1[1] = "김동록";
            s1[2] = "김동건";
            s1[3] = "전지수";
            s1[4] = "박태욱";

            string[] answer = new string[5];

            nameCompare(0, s1);

            ReadKey();
        }

        static void nameCompare(int numberCompare, string[] s1)
        {
            int temp = 0;
            char[] firstname = new char[5];
            char[] secondName = new char[5];
            char[] thirdName = new char[5];

            for (int i = 0; i < 5; i++)
            {
                char[] name = s1[i].ToCharArray();
                firstname[i] = name[numberCompare];
                secondName[i] = name[numberCompare + 1];
                thirdName[i] = name[numberCompare + 2];
            }

            for (int i = 0; i < firstname.Length; i++) // i가 배열의 크기보다 작을때 까지 i를 증가시키며 반복
            {
                int low = i; // i를 직접비교하며 교체되지 않기위해 i의 역할 대행

                for (int j = i + 1; j < firstname.Length; j++) // j는 i보다 1 큰 인덱스의 수를 비교하며 배열의 크기보다 작을때 까지 j를 증가시키며 반복
                {
                    low = j;

                    if (firstname[j] == firstname[low] && (j != low))
                    {
                        if (secondName[j] == secondName[low] && (j != low))
                        {
                            if (thirdName[j] < thirdName[low])
                            {
                                low = j;

                                temp = thirdName[low]; // 비어있는 temp변수에 arr[low]에 해당하는 숫자를 담는다
                                thirdName[low] = thirdName[i]; // low에 i인덱스의 숫자를 담는다
                                thirdName[i] = (char)temp;
                            }
                        }

                        if (secondName[j] < secondName[low])
                        {

                            low = j;

                            temp = secondName[low]; // 비어있는 temp변수에 arr[low]에 해당하는 숫자를 담는다
                            secondName[low] = secondName[i]; // low에 i인덱스의 숫자를 담는다
                            secondName[i] = (char)temp;

                            temp = thirdName[low]; // 비어있는 temp변수에 arr[low]에 해당하는 숫자를 담는다
                            thirdName[low] = thirdName[i]; // low에 i인덱스의 숫자를 담는다
                            thirdName[i] = (char)temp;

                        }
                    }

                    //이름 전체 변경

                    temp = firstname[low]; // 비어있는 temp변수에 arr[low]에 해당하는 숫자를 담는다
                    firstname[low] = firstname[i]; // low에 i인덱스의 숫자를 담는다
                    firstname[i] = (char)temp;
                    temp = secondName[low]; // 비어있는 temp변수에 arr[low]에 해당하는 숫자를 담는다
                    secondName[low] = secondName[i]; // low에 i인덱스의 숫자를 담는다
                    secondName[i] = (char)temp;
                    temp = thirdName[low]; // 비어있는 temp변수에 arr[low]에 해당하는 숫자를 담는다
                    thirdName[low] = thirdName[i]; // low에 i인덱스의 숫자를 담는다
                    thirdName[i] = (char)temp;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Write(firstname[i]);
                Write(secondName[i]);
                Write(thirdName[i]);

                WriteLine();
            }
        }
    }
}
