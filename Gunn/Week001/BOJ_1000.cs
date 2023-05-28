using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // [백준] [1000 - A + B]

        // 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

        // [입력]
        // 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

        // [출력]
        // 첫째 줄에 A+B를 출력한다.

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int result = 0;

            if (input.Length == 0)
                return;

            foreach (var num in input)
            {
                if (int.TryParse(num, out int temp))
                    result += temp;
            }

            Console.WriteLine(result);
        }
    }
}