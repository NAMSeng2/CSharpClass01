using System;

//객체 지향에서는 가장 처음에 할 일이 내가 Rpg 뭘 만들고 싶다.
//클래스를 선언한다.
//class Dragon
// {
//  int AT;
//  int Hp;
//  void Damege()
//  {
//      Hp = Hp -1;
//  }
//}

 class Player
{

    //객체지향의 캡슐화 은닉화를 대표하는 문법
    //접근제한 지정자입니다.

    public int Hp; // 외부에도 공개
    protected int Att; // 자식에게만 공개
    private int Def; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}


namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //만들어진 객체의 내용을 사용하기 위해서는
            //객체의 이름.을 사용한다.
            //접근제한 지정자라는 문법을 사용하지 않아서 공개를 안해 접근이 불가 NewPlayer. ~~

            //잘못쓰기도 힘들게 만들어 놓는것
            NewPlayer.Hp = 100;
            NewPlayer.Fight();
        }
    }
}
