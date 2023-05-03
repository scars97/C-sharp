using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class MainApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int result = Convert.ToInt32(width) * Convert.ToInt32(height);
            Console.Write("사각형의 넓이는 : " + result);


        }
    }
}
