﻿using System;

// 모든 프로그램의 근간이 되는 개념이기에 배워야함. 메모리를
// 모든 프로그램은 메모리를 지불함. 
// 메모리를 아는 것은
// 코드의 동작원리를 아는 것과 같음.
namespace _10Memory00_Func_
{
    class Program
    {
        // 요녀석을 메인 함수라고함.
        //이곳을 시작이라고 잡은 함수. c#의 규칙
        // 함수의 메모리 크기는 최소한 지역변수 이상의 크기를 가짐.
        //함수는 끝나면 메모리에서 사라짐.

        //함수의 인자값은 지역변수임.

        static void Main()
        {
            Console.WriteLine("메모리 1차 함수");
        }
    }
}