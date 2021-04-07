using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0407
{
    class Test0407
    {
        static void Main(string[] args)
        {
            // 10진수를 입력받아 2진수로 출력하는 프로그램
            // 1. 입력받는 값의 범위는 1 ~ 65535 까지
            // 2. int 배열크기를 16으로 사용하여 한개의 공간에 이진수 0,1 저장
            // 3. 10진수값을 2진수로 변경할 때 비트 범위에 맞게 출력
            // 8을 입력하면 000010000, 255를 입력하면 11111111
            // 256 입력 00000001 00000000
            // 65535 입력 11111111 11111111

            for (int a = 1; a<10; a++)
            {
                Console.Write("숫자 입력: ");
                int n = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("정보 입력: ");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            
        }
    }
}
