using System;

class Player
{
    //맴버변수 -> 클래스 내부에 있다고 해서 맴버변수

    int Att;
    int Hp;
    void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }
}//게임에서 사용하기 위해서 여기까지 설계함.


namespace _06LocalVar
{
    //c#은 고지식한 객체지향 언어
    //클래스밖에 모름
    //프로그램의 시작조차도
    //클래스 안에 묶어놔야함.

    class Program
    {
        //시작용 함수가 있는 것,
        static void Main(string[] args)
        {
            // 클래스 내부면 맴버변수, 함수 안은 지역변수.
            //함수안에 있는 녀석들을 지역변수라고 함.

            //지역변수 규칙1
            //{ 내부에서만 사용}


            int ATT = 0;
            //객체회라고 하는 굉장히 중요한 작업
            //클래스는 ? 설계도임.
            //Player의 설계대로 플레이어를 만든느데.
            //그 이름을 NewPlayer라고 해서.
            Player NewPlayer = new Player();


            // Console.WriteLine("지역변수를 공부합시다.");
        }
    }
}
