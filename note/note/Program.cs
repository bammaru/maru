using System;
using static System.Console;
using System.Collections.Generic;

namespace note
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            { "사과", "배", "수박", "복숭아", "포도"};

            myList.Add("사과");
            myList.Add("배");
            myList.Add("수박");
            myList.Add("복숭아");
            myList.Add("포도");

            Dictionary <string,int> myDict = new Dictionary<string,int>();
            myDict["수박"] = 1;
            WriteLine(myDict["수박"]);
        }
    }
}

/*

stack : 임시기억공간 
Heap : 반영구기억공간

-변수선언(괄호는 생략가능)
(한정자) 자료형 변수이름(=초기값);
   ㄴ사용범위를 좁혀줌(ex. static, const)
변수이름 : 사용자 정의명칭(숫자시작 X, 특수문자 X)

-자료형
선언 : 컴퓨터와의 약속 ex)int i;
정의 : 컴퓨터가 실행 ex)int i=0;

정수 : 숫자
-byte, short, int, long

WriteLine(byte.MaxValue); 최대값
WriteLine(byte.MinValue); 최소값
           ㄴ short, int, long

실수 : 소수
-float, double
부동소수점

문자/문자열
-char, string, 

*논리*(참거짓판단)
-bool
true false

-var

-연산자

-최우선 : ( )를 씌운걸 우선적으로
-단항=증감 : ++ -- 
-산술 : + - * /(곱하기) %(나머지) ""+""(문자열더하기) 
-쉬프트 : << n / 2의 n승만큼 곱. >> n / 2의 n승만큼 나눔
-*관계* :  이항연산자, 결과값이 논리로 true, false | < > <= >= == !=
-논리 
  ㄴ관계 : &&  || !(단항연산자)
  ㄴ비트 : & | ~ ^(XOR : 다르면 참 같으면 거짓)
-삼항=조건연산자 : (O ? O : O) 
                    ㄴ논리값
WriteLine(10%2==1 ? "홀수" : "짝수");
-대입=할당 : =(변수에다가 어떤값을 넣겠다)
-콤마 : , | 양옆 식은 다른 식

조건연산자
-제어문
조건문 : if(논리값)
{
 ~~;
}

반복문

코드에 대한 설명을 주석으로 다 쓰기
집가서 코드에 대한 목적을 쓰고 주석 복붙
그리고 설명보고 스스로 코딩

*/

/*
 
스레드
일을 병렬로 진행

-->main-------------------->
        ㄴHello------------>
즉 동시진행
ex) 캐릭터가 걸어가는것과 동시에 공격하는것
따로 할순없으니 동시에 진행


*/

/*
리스트

List<string> myList = new List<string>()
            { "사과", "배", "수박", "복숭아", "포도"};

                myList.Add("사과");
                myList.Add("배");
                myList.Add("수박");
                myList.Add("복숭아");
                myList.Add("포도");

딕셔너리


#region Thread
~~~
#endregion

접고필수있는 스레드 생성

*/



/*

게임 뭐 만들까
=테트리스?

=미로?

=떨어지는 ㅇㅇ 피하기?
떨어지는걸 피할때마다 점수획득
맞으면 하트 3개중 1개씩 마이너스


*/
