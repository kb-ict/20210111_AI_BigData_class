using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoonStep1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int N;
            int result;
            //input = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자 입력: ");
            N = int.Parse(Console.ReadLine());

            for (int j = 1; j < 10; j++)
            {
                result = N * j;
                Console.WriteLine("{0} * {1} = {2}",N,j,result);
                }
            */

            int T;
            //int A, B;
            string [] sinput = new string[2];

            int sum;
            
            T = int.Parse(Console.ReadLine());
            
            for (int i =0;    i<T;     i++)
            {
                //A = int.Parse(Console.ReadLine());
                //B = int.Parse(Console.ReadLine());
                //sum = A + B;
                sinput = Console.ReadLine().Split(' ');
                sum = int.Parse(sinput[0]) + int.Parse(sinput[1]);
                Console.WriteLine(sum);
            }

        }
    }
}
