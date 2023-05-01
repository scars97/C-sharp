using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // c# 변수 선언
            //short shortnum = 0;

            //int intNum = 0;

            //double doubleNum = 0;

            //float floatNum = 0;

            //string stringText = "";

            //char charText = 'a';

            //bool boolVal = true;

            //// .net framework 변수 선언 -> 툴에서 추천 안함
            //Int16 dotNetShort = 0;

            //Int32 dotNetInt = 0;

            //Int64 dotNetDouble = 0;

            //// 모든 변수 타입 가능
            //var dynamicType = 0;


            //// if절
            //var num = 1;
            //Console.WriteLine("0 ~ 9 사이의 값을 입력 : ");

            //// Java의 Scanner와 같은 역할
            //var input = Console.ReadLine();

            //if (num.ToString() == input)
            //{
            //    Console.WriteLine("같은 값을 입력했습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("다른 값을 입력했습니다.");
            //}


            // for문
            var forEx = 1;
            for (; forEx <= 10; forEx++)
            {
                Console.WriteLine(forEx);
            }

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
