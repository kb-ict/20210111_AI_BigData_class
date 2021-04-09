using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210408
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int result;

            Console.WriteLine("숫자입력: ");
            N = int.Parse(Console.ReadLine());

            for (int i=1;i<10;i++)
            {
                result = N * i;
                Console.WriteLine("{}*{}={}", N, i, result);
            }
        }
    }
}
