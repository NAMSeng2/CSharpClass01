using System;

class Player
{
    public int AT=10;
    public int HP=100;

    //함수의 추가 설명
    public void Damage(Monster _Monster)
    {
        HP -= _Monster.AT;
    }
}


class Monster
{
    public int AT =10;
    public int HP=100;

    //함수의 추가 설명
    public void Damage(Player _Player)
    {
        HP -= _Player.AT;
    }
}
namespace _12Memory02_Reference_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본자료형을 선언만 하면 그녀석들은 값형.
            // 자기가 만든 클래스를 new 클래스명(); 해서 만든것을 그 클래스명에 받으면 그건 레퍼런스형.

            // 클래스가 객체화된 녀석은 레퍼런스 형이라고 하고.
            // int bool이런 녀석들은 값형이라고함.

            // 값형과 레퍼런스형은 메모리와 위치의 사용법이 달라 다르게 사용됨.
            // 클래스가 값을 가지는 건 이 힙에 생성된 어떠한 메모리의 위치를 가리키는 값임.

            // . 은 안에 값을 끌어내고 싶으면 . 누르면 끌어진다 라고 얕은 이해함
            // 내가 가리키고 있는 위치에 있는 HP를 사용하겠다는 의미임.

            Monster NewMonster = new Monster();
            Player NewPlayer = new Player();

            // new로 한건 스택이 아니라 힙에 생김.
            NewMonster.Damage(NewPlayer);

            NewPlayer.Damage(NewMonster);

        }
    }
}
