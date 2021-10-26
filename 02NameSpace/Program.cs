using System;

namespace _02NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}



//클래스의 이름들은
//전문적인 용어로 식별자
//어떠한 코드를 하나로 묶는
//명칭임.
namespace MyNamespaace // 보통 프로그래머 이름으로 함.
{
    class Potion // MyNameSpace.Potion 이 되는 것
    {
        //플레이어가 마시면 HP가 차는 내용
    }
}

//네임스페이스는 개념의 표현보다 개념의 분류임

class Potion
{
    //플레이어가 마시면 MP가 차는 내용
}

//식별자가 겹칠때의 문제는 사용할 때.
//Potion쓸게 ~ 이때 문제.