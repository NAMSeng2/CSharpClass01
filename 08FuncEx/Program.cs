using System;

class Player
{
    //접근제한 지정자를 입력 안하면 디폴트로 private
    //private 가 일반적임. 속성들은 외부에서 접근 못하게 하는게 좋음.
    
    //공격력이 증가하면 증가하는 코드를 쳐야하는데 매번 코드를 쳐줘야하는 것 보단 함수가 나음.

    
    private int AT;
    private int HP;
    private int LV = 1;
    public void SetHp(int _HP)
    {
        // 내가 HP가 0이되는 순간만 체크할 수 있고.
        // 내가 100이 되는 순간만 체크할 수 있다.
        // 가장 큰 핵심은 디버깅이 된다.

        HP = _HP;
    }
    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도, 알려주는 순간 함수가 끝남.
    
    // 자신이 리턴해주려는 자료형과 동일한 자료형을 해야함.
    public int GetLV()
    {
        return LV;
    }
    public void LVUP()
    {
        AT = AT + 100;
        HP = HP + 1000;
    }
    // 플레이어가 어떤 사양과 내용을 가졌다.

    //함수는 보통 선언과 내용으로 나뉨.
      //void [리턴값] Func[이름 혹은 식별자] () [인자값]
    // (int _Dmg) 는 외부에서 값을 입력받는다는 얘기.
    //외부 값으로 내부 상태를 변화시키려고 함수를 선언하는 것이 많음.
    public void Damage( int _Dmg)
    {

    }
}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //필요한게 함수임.
            NewPlayer.SetHp(1000);
            NewPlayer.LVUP();

        }
    }
}
