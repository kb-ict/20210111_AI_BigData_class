using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0407
{
    class Program
    {
        static void Main(string[] args)
        {
            //1차원 배열 초기화
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i] + " ");//콘솔 출
                string str = string.Format("배열[{0}]: {1}", i, arrInt[i]);
                //string 문자열 자료형     {0}=i,{1}=arrInt[i]
                Console.WriteLine(str);
            }
            //1차원 배열 초기화 2
            char[] arrCh = new char[4]
            {
                '이', '박','김','최'
            };
            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
            }
            Console.WriteLine();//빈줄 출력

            //2차원 배열 초기화
            int[,] arrInt2 =
            {
                {1,2,3 },{4,5,6}
            };//2행3열의 2차원 배열
            for (int i = 0; i < 2; i++)
            {//행
                for (int j = 0; j < 3; j++)
                {//열
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //2차원 배열 초기화 2
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt3 = new int[SIZE_ROW, SIZE_COL]
            {
                {10,20,30 },
                {40,50,60 }
            };
            for (int i = 0; i < SIZE_ROW; i++)
            {//행
                for (int j = 0; j < SIZE_COL; j++)
                {//열
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }
            //2차원 배열 초기화3
            string[][] arrStr1 = new string[2][];
            arrStr1[0] = new string[] { "홍길동", "김길동", "박길동" };
            arrStr1[1] = new string[] { "전우치" };
            for (int i = 0; i < arrStr1.Length; i++)
            {
                for (int j = 0; j < arrStr1[i].Length; j++)
                {
                    Console.Write(arrStr1[i][j] + " ");
                }
                Console.WriteLine();
            }

            //2차원 배열 초기화4
            int[][] arrint4 = new int[3][];
            for (int i = 0; i < arrint4.Length; i++)
            {
                arrint4[i] = new int[i + 1];
                for (int j = 0; j < arrint4[i].Length; j++)
                {
                    arrint4[i][j] = 10 + j;
                    Console.Write(arrint4[i][j] + " ");
                }
                Console.WriteLine();
            }
            //foreach (배열 요소 in 배열) :향상된 for문
            int[] arrEach = { 1, 2, 3, 4, 5 };
            foreach (var i in arrEach) //var 타입 변수는 모든 자료형의 변수타입 runtime시점에서 i 값의 자료형에 따라
                                       // var제약 조건
                                       // 1. 지역변수만 사용가능 (중괄호 내에서만)
                                       // 2. 변수선언 및 초기화(선언과 동시에 초기화를 해야함)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // foreach 2차원

            string[,] arrEach2 =
            {
                {"홍","김"},
                {"hong","kim" }
            };
            foreach (var str in arrEach2)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            // List 자료구조: 선형구조(선형리스트) List  
            //<제네릭 클래스>: 범용적인 자료형 구조=> 클래스 안에 <인스턴스>
            List<string> list = new List<string>();//new: 객체를 생성한다 명령어
            list.Add("홍길동");
            list.Add("김길동");
            list.Add("박길동");
            list.RemoveAt(0);//첫번째 인덱스에 해당하는 값 삭제
            list.Remove("김길동"); // 값으로 삭제
            list.Insert(0, "전우치");// insert(인덱스, 값)
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            // hash table(key, value)
            // List 보다 처리 속도가 빠르다. 인덱스로 데이터 처리
            Hashtable hTable = new Hashtable();//using System.Collections;
            hTable.Add(1, "hong"); // 키와 값은 object형 hTable.Add(object key, object value); boxing 
            hTable.Add(2, "kim");

            if(hTable.Contains(1))// 키 값 1이 존재하면 
            {
                Console.WriteLine(hTable[1]); // 해당키의 값을 출력
            }
            //딕셔너리
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key1", "hong1");
            dic.Add("key2", "hong2");
            dic.Add("key3", "hong3");
            
            foreach(KeyValuePair<string,string>item in dic)
            {
                Console.WriteLine("{0}", item);
            }
           foreach(string key in dic.Keys)//딕셔너리 내 모든 키값출력
            {
                Console.WriteLine(key);
            }
           foreach(string value in dic.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("값: {0}", dic["key2"]);
        }
    }
}
