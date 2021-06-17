using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0407
{
    class Text0407
    {
        static void Main(string[]args)
        {
            //10진수로 입력받아 2진수로 출력하는 프로그램
            //조건 1. 입력받는 값의 범위는 1~65535까지
            //     2. int 배열크기를 16으로 사용하여 한개의 공간에 이진수 0,1 저장
            //     3. 10진수 값을 이진수로 변경할 때 비트 범위에 맞게 출력
            //--> 8을 입력하면 00001000, 255를 입력하면 11111111
            //-->256입력 00000001 00000000
            //-->65535입력 111111111 11111111

            //입력받기
           // Console.Write("정보 입력: ");
            //string str = Console.ReadLine();//기본 stringㅇ으로 값을 받는다
            //int num = Convert.ToInt32(str);//int로 자료형변환 Convert.ToInt32();

            Console.Write("숫자(1~165535) 입력: ");
            int n = Convert.ToInt32(Console.ReadLine());// 값을 (string으로) 받아 int형으로 자료형 변환하여 int형 변수에 저장
            int[] binarr = dec2bin(n);
            int start = binarr.Length - 1;
            if(n<=255)
            {
                start = 7;
            }
            else if(n<=65535)
            {
                start = 15;
            }

            for(int i=start; i>=0; i--)
            {
                Console.Write(binarr[i]);
            }
            Console.WriteLine();
 
        }
        public static int[] dec2bin(int n)
        {
            int[] nam = new int[16];
            int i = 0;
            while (n != 1)
            {
                nam[i++] = n % 2;

                n /= 2;
            }
            nam[i] = n;
            return nam;
        }

    }
}
