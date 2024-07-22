using System.Runtime.CompilerServices;

namespace OOP_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #region 과제 1. Character 클래스 선언하기
    // Character 클래스를 선언하고 필드와 메서드 선언
    public class Character
    {
        int _level;
        int _hp;
        float _moveSpeed;
        int _attackPoint;

        // 전진
        public void Forward()
        {
            Console.WriteLine($"{_moveSpeed}의 속도로 전진합니다.");
        }

        // 후진
        public void Backward()
        {
            Console.WriteLine($"{_moveSpeed}의 속도로 후진합니다.");
        }

        // 좌회전 (90도)
        public void RotateLeft()
        {
            Console.WriteLine("좌로 90도 회전합니다.");
        }

        // 우회전(90도)
        public void RotateRight()
        {
            Console.WriteLine("우로 90도 회전합니다.");
        }

        // 공격
        public void Attack(Character target)
        {
            target.OnDamaged(_attackPoint);
        }

        // 피격
        public void OnDamaged(int damage)
        {
            _hp -= damage;

            if (_hp <= 0)
            {
                // TODO : OnDead 처리
            }
        }
    }
    #endregion
}
